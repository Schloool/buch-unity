using UnityEngine;

public class EnemyTest : MonoBehaviour
{
    private void Start()
    {
        Enemy slowEnemy = new Enemy();
        Enemy fastEnemy = new Enemy();

        slowEnemy.speed = 2.5f;
        fastEnemy.speed = 10f;
        
        slowEnemy.Walk();
        fastEnemy.Walk();
    }
}