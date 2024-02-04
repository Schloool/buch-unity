using UnityEngine;

public class ZombieInstantiatorDeactivation : MonoBehaviour
{
    [SerializeField] private GameObject zombiePrefab;

    private void Start()
    {
        GameObject newObject = Instantiate(zombiePrefab);
        newObject.SetActive(false);
    }
}