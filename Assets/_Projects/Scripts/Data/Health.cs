using UnityEngine;

public class Health : MonoBehaviour, IDamageable
{
    [SerializeField] private float _maxHealth = 100f;

    public float Current { get; private set; }
    public bool IsDead => Current <= 0f;

    public event System.Action<float> Damaged;   // The damage taken
    public event System.Action Died;

    private void Awake() => Current = _maxHealth;

    public void ApplyDamage(float amount) {
        if (IsDead)
            return;

        Current = Mathf.Max(0f, Current - amount);
        Damaged?.Invoke(amount); // Event mainly for enemyAI

        if (IsDead)
            Died?.Invoke();
    }
}