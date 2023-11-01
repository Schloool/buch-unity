using System.Collections;
using UnityEngine;

public class PlatformEnemy : MonoBehaviour
{
    [SerializeField] private PlatformEnemyProjectile projectilePrefab;
    [SerializeField] private float shotFrequency;
    [SerializeField] private float minPlayerDistance;

    private IEnumerator Start()
    {
        Transform playerTransform = FindObjectOfType<PlatformPlayerMovement>().transform;
        
        while (true)
        {
            yield return new WaitForSeconds(shotFrequency);

            if (Vector3.Distance(playerTransform.position, transform.position) <= minPlayerDistance)
            {
                Instantiate(projectilePrefab, transform.position, Quaternion.identity);
            }
        }
    }
}