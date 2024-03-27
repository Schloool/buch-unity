using System;
using UnityEngine;

/// <summary>
/// Verwaltungsscript für die Lebenspunkte, die der Spieler noch zur Verfügung hat, bis das Spiel als verloren gilt.
/// </summary>
public class TowerPlayerHealth : MonoBehaviour
{
    public event Action<float> OnHealthUpdate;
    
    public float MaxHealth => maxHealth;

    [SerializeField] private float maxHealth;
    
    private float currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    /// <summary>
    /// Zieht dem Spieler eine gegebene Anzahl an Lebenspunkten ab.
    /// </summary>
    public void Damage(float damage)
    {
        if (damage < 0f) throw new ArgumentException("Damage must be higher than 0.");
        
        currentHealth -= damage;
        OnHealthUpdate?.Invoke(currentHealth);
    }
}