using System;
using UnityEngine;

/// <summary>
/// Verwaltungsscript für die Lebenspunkte des Spielers.
/// </summary>
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

    /// <summary>
    /// Fügt dem Spieler einen Schadenspunkt zu.
    ///
    /// Sind keine Lebenspunkte mehr übrig, wird der Tod des Spielers gemeldet.
    /// </summary>
    public void Damage()
    {
        if (currentHealth <= 0) return;

        currentHealth--;
        OnHealthUpdate?.Invoke(currentHealth);

        if (currentHealth <= 0)
        {
            OnDeath?.Invoke();
        }
    }

    /// <summary>
    /// Leitet den Tod des Spielers ein, indem alle verbleibenden Lebenspunkte entfernt werden.
    /// </summary>
    private void Kill()
    {
        for (int i = 0; i < currentHealth; i++)
        {
            Damage();
        }
    }
}