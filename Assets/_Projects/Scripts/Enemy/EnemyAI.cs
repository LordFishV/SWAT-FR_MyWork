using UnityEngine;
using UnityEngine.AI;

// Mimics Ready or Not style suspect mechanics.
[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Health))]
public class EnemyAI : MonoBehaviour
{
    [Header("References")]
    [Tooltip("Empty object at head height, facing forward. Falls back to this object.")]
    [SerializeField] private Transform _eyes;
    [Tooltip("Layers that block sight and bullets: the Floors, Walls and the Player.")]
    [SerializeField] private LayerMask _sightMask = ~0;
    [SerializeField] private AudioClip _shotSound;
    [Tooltip("Optional. Changes colour by state so you can see what the AI is doing.")]
    [SerializeField] private Renderer _debugRenderer;

    [Header("Senses")]
    [SerializeField] private float _sightRange = 25f;
    [SerializeField] private float _fieldOfView = 120f;
    [Tooltip("Seconds without seeing the player before giving up the search.")]
    [SerializeField] private float _searchTime = 8f;

    [Header("Combat")]
    [SerializeField] private float _attackRange = 15f;
    [Tooltip("0 for an unarmed suspect.")]
    [SerializeField] private float _damage = 8f;
    [SerializeField] private float _shotsPerSecond = 2f;
    [Tooltip("0 = wild (misses by up to 8 degrees), 1 = deadly (1 degree).")]
    [Range(0f, 1f)][SerializeField] private float _accuracy = 0.4f;
    [SerializeField] private float _walkSpeed = 3.5f;
    [SerializeField] private float _runSpeed = 5.5f;

    [Header("Morale (0 = broken, 100 = fearless)")]
    [Tooltip("Each suspect starts with a random morale in this range. (Default: 60, 100)")]
    [SerializeField] private Vector2 _startMoraleRange = new Vector2(60f, 100f);
    [Tooltip("The minimum moral where the enemy will flee")]
    [SerializeField] private float _fleeBelow = 50f;
    [SerializeField] private float _surrenderBelow = 30f;
    [SerializeField] private float _damageMoraleHit = 15f;
    [SerializeField] private float _flashMoraleHit = 45f;
    [SerializeField] private float _commandMoraleHit = 35f;
    [Tooltip("A fleeing suspect closer than this to the player gives up.")]
    [SerializeField] private float _corneredDistance = 4f;

    public EnemyState State { get; private set; } = EnemyState.Idle;
    public bool IsSurrendering => State == EnemyState.Surrender && !Arrested;
    public bool Arrested { get; private set; }

    private NavMeshAgent _agent;
    private Health _health;
    private Blindable _blindable;
    private Transform _player;

    private float _morale;
    private float _nextShotTime;
    private float _nextRepathTime;
    private float _lostSightTimer;
    private Vector3 _lastKnownPosition;
    private bool _wasBlinded;

    private void Awake() {
        _agent = GetComponent<NavMeshAgent>();
        _health = GetComponent<Health>();
        _blindable = GetComponent<Blindable>();

        if (_eyes == null)
            _eyes = transform;

        _morale = Random.Range(_startMoraleRange.x, _startMoraleRange.y);
    }

    private void Start() {
        PlayerCharacter player = FindFirstObjectByType<PlayerCharacter>();
        if (player != null)
            _player = player.transform;
        else
            Debug.LogWarning("SuspectAI: no Player found in the scene.", this);

        Enter(EnemyState.Idle);
    }

    private void OnEnable() {
        _health.Damaged += OnDamaged;
        _health.Died += OnDied;
    }

    private void OnDisable() {
        _health.Damaged -= OnDamaged;
        _health.Died -= OnDied;
    }

    private void Update() {
        if (Arrested || _player == null)
            return;
        //State == EnemyState.Dead || 

        CheckForFlash();

        switch (State) {
            case EnemyState.Idle: UpdateIdle(); break;
            case EnemyState.Attack: UpdateAttack(); break;
            case EnemyState.Flee: UpdateFlee(); break;
            case EnemyState.Dead: Destroy(gameObject); break;
                // Surrender: stands still with nothing to do
        }

        UpdateDebugColor();
    }

    // ---------- States ----------

    private void UpdateIdle() {
        if (CanSeePlayer()) {
            _lastKnownPosition = _player.position;
            Enter(EnemyState.Attack);
        }
    }

    private void UpdateAttack() {
        // When blinded, stands still and prevent shooting
        if (_blindable != null && _blindable.IsBlinded) {
            _agent.isStopped = true;
            return;
        }

        bool canSee = CanSeePlayer();
        float distance = Vector3.Distance(transform.position, _player.position);

        if (canSee) {
            _lastKnownPosition = _player.position;
            _lostSightTimer = 0f;
        } else {
            _lostSightTimer += Time.deltaTime;
            if (_lostSightTimer > _searchTime) {
                Enter(EnemyState.Idle);
                return;
            }
        }

        if (canSee && distance <= _attackRange) {
            // Can shoot, then stop, face the player and shoot
            _agent.isStopped = true;
            FaceTowards(_player.position);

            if (Time.time >= _nextShotTime)
                Shoot();
        } else {
            // Move to player or last seen location
            _agent.isStopped = false;

            if (Time.time >= _nextRepathTime) {
                _nextRepathTime = Time.time + 0.25f;
                _agent.SetDestination(_lastKnownPosition);
            }
        }
    }
    /// <summary>Run away from the the player if possable, if not surrender</summary>
    private void UpdateFlee() {
        // If the player is close, give up
        if (Vector3.Distance(transform.position, _player.position) < _corneredDistance) {
            Enter(EnemyState.Surrender);
            return;
        }

        if (Time.time < _nextRepathTime)
            return;

        _nextRepathTime = Time.time + 0.5f;

        // Run directly away from the player
        Vector3 away = (transform.position - _player.position).normalized;
        if (NavMesh.SamplePosition(transform.position + away * 10f, out NavMeshHit hit, 5f, NavMesh.AllAreas))
            _agent.SetDestination(hit.position);
        else
            Enter(EnemyState.Surrender);   // nowhere left to run
    }

    /// <summary>Enter State new EnemyState</summary>
    /// <param name="newState">Enemy State enum</param>
    private void Enter(EnemyState newState) {
        State = newState;

        switch (newState) {
            case EnemyState.Idle:
                _agent.isStopped = true;
                break;

            case EnemyState.Attack:
                _agent.isStopped = false;
                _agent.speed = _walkSpeed;
                _lostSightTimer = 0f;
                break;

            case EnemyState.Flee:
                _agent.isStopped = false;
                _agent.speed = _runSpeed;
                _nextRepathTime = 0f;
                break;

            case EnemyState.Surrender:
                _agent.isStopped = true;
                _agent.ResetPath();
                break;

            case EnemyState.Dead:
                _agent.isStopped = true;
                _agent.enabled = false;
                break;
        }

        UpdateDebugColor();
    }

    // Morale
    private void ApplyMoraleHit(float amount) {
        if (State == EnemyState.Dead || State == EnemyState.Surrender)
            return;

        _morale = Mathf.Max(0f, _morale - amount);

        if (_morale < _surrenderBelow)
            Enter(EnemyState.Surrender);
        else if (_morale < _fleeBelow && State != EnemyState.Flee)
            Enter(EnemyState.Flee);
    }

    private void OnDamaged(float amount) {
        if (State == EnemyState.Dead || _player == null)
            return;

        // Being shot makes an unaware enemy aware of the player
        if (State == EnemyState.Idle) {
            _lastKnownPosition = _player.position;
            Enter(EnemyState.Attack);
        }

        ApplyMoraleHit(_damageMoraleHit);
    }

    private void OnDied() {
        Enter(EnemyState.Dead);
    }

    // Flashbangs: the Blindable component flags when a flash lands
    private void CheckForFlash() {
        if (_blindable == null)
            return;

        bool blinded = _blindable.IsBlinded;

        if (blinded && !_wasBlinded)
            ApplyMoraleHit(_flashMoraleHit);

        _wasBlinded = blinded;
    }

    // Player interaction

    // Called by PlayerCommand when the player commands this enemy
    public void OnCommanded() {
        if (State == EnemyState.Dead || _player == null)
            return;

        if (State == EnemyState.Idle) {
            _lastKnownPosition = _player.position;
            Enter(EnemyState.Attack);
        }

        ApplyMoraleHit(_commandMoraleHit);
    }

    public void Arrest() {
        if (!IsSurrendering)
            return;

        Arrested = true;
        UpdateDebugColor();
        Debug.Log($"{name} arrested.");
    }


    // Senses and shooting

    private bool CanSeePlayer() {
        if (_blindable != null && _blindable.IsBlinded)
            return false;

        Vector3 toPlayer = (_player.position + Vector3.up) - _eyes.position;

        if (toPlayer.magnitude > _sightRange)
            return false;

        if (Vector3.Angle(_eyes.forward, toPlayer) > _fieldOfView * 0.5f)
            return false;

        // Nothing solid in the way, and what we hit is the player
        return Physics.Raycast(_eyes.position, toPlayer.normalized, out RaycastHit hit,
                   _sightRange, _sightMask, QueryTriggerInteraction.Ignore)
               && hit.transform.IsChildOf(_player);
    }

    private void Shoot() {
        _nextShotTime = Time.time + 1f / _shotsPerSecond;

        if (_damage <= 0f)
            return;

        Vector3 origin = _eyes.position;
        Vector3 aimPoint = _player.position + Vector3.up * 1.2f;
        Vector3 direction = (aimPoint - origin).normalized;

        // randomise shot cone
        float spread = Mathf.Lerp(8f, 1f, _accuracy);
        Vector2 offset = Random.insideUnitCircle * Mathf.Tan(spread * Mathf.Deg2Rad);
        direction = (Quaternion.LookRotation(direction) * new Vector3(offset.x, offset.y, 1f)).normalized;

        if (Physics.Raycast(origin, direction, out RaycastHit hit, _attackRange * 2f,
                _sightMask, QueryTriggerInteraction.Ignore)) {
            // So Enemies don't shoot each other
            IDamageable victim = hit.collider.GetComponentInParent<IDamageable>();
            if (victim != null && hit.collider.GetComponentInParent<EnemyAI>() == null)
                victim.ApplyDamage(_damage);
        }

        Debug.DrawRay(origin, direction * 20f, Color.red, 0.2f);

        if (_shotSound != null)
            AudioSource.PlayClipAtPoint(_shotSound, origin);
    }

    private void FaceTowards(Vector3 point) {
        Vector3 flat = point - transform.position;
        flat.y = 0f;

        if (flat.sqrMagnitude < 0.01f)
            return;

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(flat), 8f * Time.deltaTime);
    }

    private void UpdateDebugColor() {
        if (_debugRenderer == null)
            return;

        Color color = Arrested ? Color.blue : State switch {
            EnemyState.Attack => Color.red,
            EnemyState.Flee => Color.yellow,
            EnemyState.Surrender => Color.green,
            EnemyState.Dead => Color.black,
            _ => Color.white
        };

        _debugRenderer.material.color = color;
    }
}