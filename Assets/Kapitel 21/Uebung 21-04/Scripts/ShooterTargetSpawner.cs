using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

/// <summary>
/// Script für das regelmäßige Platzieren neuer Zielscheiben in der Scene.
/// </summary>
public class ShooterTargetSpawner : MonoBehaviour
{
    [SerializeField] private ShooterTarget targetPrefab;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float spawnInterval = 3.5f;

    private ShooterPointCounter pointCounter;
    private ShooterTimer timer;

    private void Awake()
    {
        pointCounter = GetComponent<ShooterPointCounter>();
        timer = GetComponent<ShooterTimer>();
    }

    private void Start()
    {
        // Zum Start des Spiels sollen 10 Scheiben in der Scene platziert werden.
        for (int i = 0; i < 10; i++)
        {
            SpawnTarget();
        }

        StartCoroutine(SpawnRoutine());
    }

    /// <summary>
    /// Erschafft ein neues Ziel in der Scene.
    ///
    /// Die Position wird zufällig bestimmt, die Scheibe schaut außerdem automatisch den Spieler an.
    /// </summary>
    private void SpawnTarget()
    {
        float x = Random.Range(0.05f, 1f) * (Random.value > 0.5f ? 1f : -1f);
        float y = Random.Range(0.5f, 0.1f);
        float z = Random.Range(0.05f, 1f) * (Random.value > 0.5f ? 1f : -1f);
        Vector3 randomPoint = new Vector3(x, y, z).normalized * Random.Range(6f, 14f);

        ShooterTarget target = Instantiate(targetPrefab, randomPoint, Quaternion.identity);
        target.transform.LookAt(playerTransform);
        
        target.OnHit += HandleTargetHit;
    }
    
    /// <summary>
    /// Coroutine, durch die in regelmäßigen Zeitabständen neue Zielscheiben in der Scene erscheinen.
    /// </summary>
    private IEnumerator SpawnRoutine()
    {
        yield return null;
        
        while (!timer.HasFinished)
        {
            yield return new WaitForSeconds(spawnInterval);
            SpawnTarget();
        }
    }

    /// <summary>
    /// Behandelt das Treffen einer Zielscheibe, indem dem Timer mehr Zeit hinzugefügt wird und eine neue Zielscheibe
    /// erscheint.
    /// </summary>
    private void HandleTargetHit(ShooterTarget target)
    {
        pointCounter.AddPointsForDistance(Vector3.Distance(target.transform.position, playerTransform.position));
        timer.AddTime(1f);
        SpawnTarget();
        
        target.OnHit -= HandleTargetHit;
    } 
}