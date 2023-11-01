using System;
using UnityEngine;

public class TowerPlayerHealth : MonoBehaviour
{
    public event Action<float> OnHealthUpdate;
    
    public float MaxHealth => maxHealth;

    [SerializeField] private float maxHealth;
    
    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void Damage(float damage)
    {
        if (damage < 0f) throw new ArgumentException("Damage must be higher than 0.");
        
        currentHealth -= damage;
        OnHealthUpdate?.Invoke(currentHealth);
    }
}