using UnityEngine;

public class ZombieParentInstantiator : MonoBehaviour
{
    [SerializeField] private GameObject zombiePrefab;
    [SerializeField] private bool worldPositionStays;

    private void Start()
    {
        Instantiate(zombiePrefab, transform, worldPositionStays);
    }
}