using System.Collections;
using UnityEngine;

public class FlappyObstacleSpawner : MonoBehaviour
{
    [SerializeField] private FlappyObstacle obstaclePrefab;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;
    [SerializeField] private float minSeconds;
    [SerializeField] private float maxSeconds;
    [SerializeField] private float maxRockOffset;

    private IEnumerator Start()
    {
        while (true)
        {
            Vector3 randomPos = new Vector3(transform.position.x, Random.Range(minY, maxY));
            FlappyObstacle obstacle = Instantiate(obstaclePrefab, randomPos, Quaternion.identity, transform);
            obstacle.rockDown.transform.position += Vector3.down * Random.Range(0f, maxRockOffset);

            yield return new WaitForSeconds(Random.Range(minSeconds, maxSeconds));
        }
    }
}