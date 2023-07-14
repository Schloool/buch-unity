using System.Collections;
using UnityEngine;

public class FireworkSpawner : MonoBehaviour
{
    [SerializeField] private GameObject fireworkPrefab;
    
    private IEnumerator Start()
    {
        while (true)
        {
            Vector3 pos = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f));
            Instantiate(fireworkPrefab, pos, Quaternion.identity);

            yield return new WaitForSeconds(2f);
        }
    }
}
