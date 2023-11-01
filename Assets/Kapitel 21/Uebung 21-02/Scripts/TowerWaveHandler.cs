using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TowerWaveHandler : MonoBehaviour
{
    public event Action<int> OnChangeWave;
    
    public List<TowerEnemy> ActiveEnemies { get; private set; }
    public int CurrentWave { get; private set; }
    
    [SerializeField] private TowerEnemy enemyPrefab;
    [SerializeField] private TowerEnemyType[] enemyTypes;
    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform targetPoint;

    private TowerMoneyHandler moneyHandler;
    
    private IEnumerator Start()
    {
        moneyHandler = GetComponent<TowerMoneyHandler>();
        
        CurrentWave = 1;
        ActiveEnemies = new List<TowerEnemy>();

        while (true)
        {
            OnChangeWave?.Invoke(CurrentWave);
            for (int i = 0; i < CurrentWave * 2.5f; i++)
            {
                SpawnEnemy();
                yield return new WaitForSeconds(0.75f);
            }
            
            yield return new WaitUntil(() => ActiveEnemies.Count == 0);
            CurrentWave++;
        }
    }

    private void SpawnEnemy()
    {
        TowerEnemy enemy = Instantiate(enemyPrefab, startPoint.position, Quaternion.identity);
        TowerEnemyType randomType = enemyTypes[Random.Range(0, enemyTypes.Length)];
        enemy.Initialize(this, randomType, targetPoint.position);
        
        ActiveEnemies.Add(enemy);
        enemy.OnDeath += HandleEnemyDeath;
    }

    private void HandleEnemyDeath(TowerEnemy enemy)
    {
        ActiveEnemies.Remove(enemy);
        moneyHandler.AddMoney((uint) Mathf.Max(enemy.Type.moneyOnKill - CurrentWave * 1.2f, 2));
        enemy.OnDeath -= HandleEnemyDeath;
    }
}