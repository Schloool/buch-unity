using UnityEngine;

public class CubeInstantiatorDeactivation : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;

    private void Start()
    {
        GameObject newObject = Instantiate(cubePrefab);
        newObject.SetActive(false);
    }
}