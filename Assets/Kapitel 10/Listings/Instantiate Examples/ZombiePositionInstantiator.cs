using UnityEngine;

public class ZombiePositionInstantiator : MonoBehaviour
{
    [SerializeField] private GameObject zombiePrefab;

    private void Start()
    {
        Vector3 position = new Vector3(2f, 2f, 2f);
        Instantiate(zombiePrefab, position, Quaternion.identity);
    }
}