using UnityEngine;

public class SimpleEnemyInstantiator : MonoBehaviour
{
    [SerializeField] private SimpleEnemy enemyPrefab;

    private void Start()
    {
        SimpleEnemy newEnemy = Instantiate(enemyPrefab);
        newEnemy.PrintSpeed();
    }
}