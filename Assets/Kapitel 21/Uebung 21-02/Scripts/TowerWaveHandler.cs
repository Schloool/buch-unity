using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

/// <summary>
/// Verwaltungsscript für die Wellen, die im Laufe des Spiels ausgelöst werden, um mehrere Gegner zu erschaffen.
/// </summary>
public class TowerWaveHandler : MonoBehaviour
{
    public event Action<int> OnChangeWave;

    public int CurrentWave { get; private set; }
    
    [SerializeField] private TowerEnemy enemyPrefab;
    [SerializeField] private TowerEnemyType[] enemyTypes;
    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform targetPoint;
    [SerializeField] private float enemiesPerWaveMultiplicator = 2.5f;
    [SerializeField] private float enemySpawnDelay = 0.75f;

    private TowerMoneyHandler moneyHandler;
    private List<TowerEnemy> activeEnemies;

    private void Awake()
    {
        moneyHandler = GetComponent<TowerMoneyHandler>();
    }

    private IEnumerator Start()
    {
        CurrentWave = 1;
        activeEnemies = new List<TowerEnemy>();

        while (true)
        {
            OnChangeWave?.Invoke(CurrentWave);
            for (int i = 0; i < CurrentWave * enemiesPerWaveMultiplicator; i++)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(enemySpawnDelay);
            }
            
            // Die nächste Welle soll starten, sobald alle Gegner der aktuellen Welle getötet wurden.
            yield return new WaitUntil(() => activeEnemies.Count == 0);
            CurrentWave++;
        }
    }

    /// <summary>
    /// Gibt den Gegner zurück, der sich am nächsten an einem gegebenen Punkt befindet.
    /// </summary>
    public TowerEnemy GetClosestEnemyToPoint(Vector3 point)
    {
        return activeEnemies
            .OrderBy(enemy => Vector3.Distance(enemy.transform.position, transform.position))
            .FirstOrDefault();
    }

    /// <summary>
    /// Erschafft einen neuen Gegner.
    /// 
    /// Der Typ des Gegners wird dabei zufällig aus der Liste aller Typen gewählt.
    /// </summary>
    private void SpawnEnemy()
    {
        TowerEnemy enemy = Instantiate(enemyPrefab, startPoint.position, Quaternion.identity);
        TowerEnemyType randomType = enemyTypes[Random.Range(0, enemyTypes.Length)];
        enemy.Initialize(this, randomType, targetPoint.position);
        
        activeEnemies.Add(enemy);
        enemy.OnDeath += HandleEnemyDeath;
    }

    /// <summary>
    /// Behandelt den Tod eines Gegners aus der aktuellen Welle.
    /// </summary>
    private void HandleEnemyDeath(TowerEnemy enemy)
    {
        activeEnemies.Remove(enemy);
        moneyHandler.AddMoney((uint) Mathf.Max(enemy.Type.moneyOnKill - CurrentWave * 1.2f, 2));
        enemy.OnDeath -= HandleEnemyDeath;
    }
}