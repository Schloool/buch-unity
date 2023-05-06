using UnityEngine;

public class CubePositionInstantiator : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;

    private void Start()
    {
        Vector3 position = new Vector3(2f, 2f, 2f);
        Instantiate(cubePrefab, position, Quaternion.identity);
    }
}