using UnityEngine;

public class PlayerCommand : MonoBehaviour
{
    [SerializeField] private float _shoutRange = 15f;
    [SerializeField] private float _shoutAngle = 60f;
    [SerializeField] private float _arrestRange = 3f;
    [SerializeField] private float _cooldown = 1.5f;
    [SerializeField] private AudioClip _shoutSound;
    [Tooltip("Layers that block the shout: the world, plus the suspects.")]
    [SerializeField] private LayerMask _sightMask = ~0;

    private float _nextTime;

    public void Command(Transform aim) {
        if (Time.time < _nextTime)
            return;

        _nextTime = Time.time + _cooldown;

        // Arrest a surrendering enemy infront of the player
        if (Physics.Raycast(aim.position, aim.forward, out RaycastHit hit, _arrestRange, _sightMask,
                QueryTriggerInteraction.Ignore)) {
            EnemyAI target = hit.collider.GetComponentInParent<EnemyAI>();
            if (target != null && target.IsSurrendering) {
                target.Arrest();
                return;
            }
        }

        // Otherwise shout
        if (_shoutSound != null)
            AudioSource.PlayClipAtPoint(_shoutSound, aim.position);

        foreach (EnemyAI suspect in FindObjectsByType<EnemyAI>(FindObjectsSortMode.None)) {
            Vector3 point = suspect.transform.position + Vector3.up;
            Vector3 toSuspect = point - aim.position;

            if (toSuspect.magnitude > _shoutRange || Vector3.Angle(aim.forward, toSuspect) > _shoutAngle)
                continue;

            // Walls block the shout
            if (Physics.Linecast(aim.position, point, out RaycastHit block, _sightMask,
                    QueryTriggerInteraction.Ignore) && !block.transform.IsChildOf(suspect.transform))
                continue;

            suspect.OnCommanded();
        }
    }
}