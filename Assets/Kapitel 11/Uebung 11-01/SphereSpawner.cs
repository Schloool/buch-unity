using UnityEngine;

public class SphereSpawner : MonoBehaviour
{
    [SerializeField] private GameObject spherePrefab;

    private void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            Vector3 pos = new Vector3(GetRandom(), GetRandom(), GetRandom());
            Instantiate(spherePrefab, pos, Quaternion.identity);
        }
    }

    private float GetRandom()
    {
        return Random.Range(-5f, 5f);
    }
}