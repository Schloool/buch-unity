using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class ShooterTargetSpawner : MonoBehaviour
{
    [SerializeField] private ShooterTarget targetPrefab;
    [SerializeField] private Transform playerTransform;
    
    private ShooterPointCounter pointCounter;
    private ShooterTimer timer;

    private void Awake()
    {
        pointCounter = GetComponent<ShooterPointCounter>();
        timer = GetComponent<ShooterTimer>();
    }

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            SpawnTarget();
        }

        StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        yield return null;
        
        while (timer.RemainingTime > 0f)
        {
            yield return new WaitForSeconds(3.5f);
            SpawnTarget();
        }
    }

    private void SpawnTarget()
    {
        float x = Random.Range(0.05f, 1f) * (Random.value > 0.5f ? 1f : -1f);
        float y = Random.Range(0.5f, 0.1f);
        float z = Random.Range(0.05f, 1f) * (Random.value > 0.5f ? 1f : -1f);
        Vector3 randomPoint = new Vector3(x, y, z).normalized * Random.Range(6f, 14f);

        ShooterTarget target = Instantiate(targetPrefab, randomPoint, Quaternion.identity);
        target.PlayerTransform = playerTransform;
        
        target.OnHit += HandleTargetHit;
    }

    private void HandleTargetHit(ShooterTarget target)
    {
        pointCounter.AddPointsForDistance(Vector3.Distance(target.transform.position, playerTransform.position));
        timer.AddTime(1f);
        SpawnTarget();
        
        target.OnHit -= HandleTargetHit;
    } 
}