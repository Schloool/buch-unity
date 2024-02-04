using UnityEngine;

public class ZombieSpeedInstantiator : MonoBehaviour
{
    [SerializeField] private Zombie zombiePrefab;

    private void Start()
    {
        Zombie zombie = Instantiate(zombiePrefab);
        zombie.PrintSpeed();
    }
}