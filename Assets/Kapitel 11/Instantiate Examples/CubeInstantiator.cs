using UnityEngine;

public class CubeInstantiator : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;

    private void Start()
    {
        Instantiate(cubePrefab);
    }
}