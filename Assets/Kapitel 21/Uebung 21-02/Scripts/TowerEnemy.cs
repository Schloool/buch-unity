using System;
using UnityEngine;
using UnityEngine.AI;

public class TowerEnemy : MonoBehaviour
{
    public event Action<TowerEnemy> OnDeath;

    public TowerEnemyType Type { get; private set; }

    private NavMeshAgent agent;
    private float healthPoints;

    public void Initialize(TowerWaveHandler waveHandler, TowerEnemyType enemyType, Vector3 targetPoint)
    {
        agent = GetComponent<NavMeshAgent>();
        Type = enemyType;
        
        Instantiate(enemyType.model, transform);
        agent.speed = enemyType.speed + waveHandler.CurrentWave * 0.2f;
        agent.SetDestination(targetPoint);

        healthPoints = enemyType.healthPoints + waveHandler.CurrentWave * 10f;
    }

    public void Damage(float damage)
    {
        if (damage < 0f) throw new ArgumentException("Damage must be higher than 0.");
        
        healthPoints -= damage;
        if (healthPoints > 0f) return;

        Kill();
    }

    public void Kill()
    {
        OnDeath?.Invoke(this);
        Destroy(gameObject);
    }
}