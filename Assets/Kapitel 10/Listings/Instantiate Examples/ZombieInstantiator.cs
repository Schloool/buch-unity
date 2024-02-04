using UnityEngine;

public class ZombieInstantiator : MonoBehaviour
{
    [SerializeField] private GameObject zombiePrefab;

    private void Start()
    {
        Instantiate(zombiePrefab);
    }
}