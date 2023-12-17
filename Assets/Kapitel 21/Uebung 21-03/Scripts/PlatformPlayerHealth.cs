using System;
using UnityEngine;

public class PlatformPlayerHealth : MonoBehaviour
{
    public event Action<int> OnHealthUpdate;
    public event Action OnDeath;
    
    public int MaxHealth { get; private set; }
    
    [SerializeField] private int currentHealth = 3;

    private void Awake()
    {
        MaxHealth = currentHealth;
    }

    private void FixedUpdate()
    {
        if (transform.position.y < -5f)
        {
            Kill();
        }
    }

    public void Damage()
    {
        if (currentHealth <= 0) return;
        
        OnHealthUpdate?.Invoke(--currentHealth);

        if (currentHealth <= 0)
        {
            OnDeath?.Invoke();
        }
    }

    private void Kill()
    {
        for (int i = 0; i < currentHealth; i++)
        {
            Damage();
        }
    }
}