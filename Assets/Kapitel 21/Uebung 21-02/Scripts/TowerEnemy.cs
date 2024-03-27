using System;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Script für einen Gegner, der während einer Welle versucht, sich zum Ziel zu begeben und dem Spieler so Schaden
/// zuzufügen. 
/// </summary>
public class TowerEnemy : MonoBehaviour
{
    public event Action<TowerEnemy> OnDeath;

    public TowerEnemyType Type { get; private set; }

    private NavMeshAgent agent;
    private float healthPoints;

    /// <summary>
    /// Initialisiert diesen Gegner, indem bestimmte Grunddaten 
    /// </summary>
    public void Initialize(TowerWaveHandler waveHandler, TowerEnemyType enemyType, Vector3 targetPoint)
    {
        agent = GetComponent<NavMeshAgent>();
        Type = enemyType;
        
        Instantiate(enemyType.model, transform);
        agent.speed = enemyType.speed + waveHandler.CurrentWave * 0.2f;
        agent.SetDestination(targetPoint);

        healthPoints = enemyType.healthPoints + waveHandler.CurrentWave * 10f;
    }

    /// <summary>
    /// Fügt diesem Gegner Schaden zu.
    /// Werden die Lebenspunkte des Gegners unterschritten, so stirbt er.
    /// </summary>
    public void Damage(float damage)
    {
        if (damage < 0f) throw new ArgumentException("Damage must be higher than 0.");
        
        healthPoints -= damage;
        if (healthPoints <= 0f)
        {
            Kill();
        }
    }

    /// <summary>
    /// Tötet diesen Gegner.
    /// </summary>
    public void Kill()
    {
        OnDeath?.Invoke(this);
        Destroy(gameObject);
    }
}