using UnityEngine;

public class CubeParentInstantiator : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private bool worldPositionStays;

    private void Start()
    {
        Instantiate(cubePrefab, transform, worldPositionStays);
    }
}