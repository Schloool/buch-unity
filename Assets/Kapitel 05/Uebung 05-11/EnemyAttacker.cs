using UnityEngine;

public class EnemyAttacker : MonoBehaviour
{
    private void Start()
    {
        int enemyHealth = 50;
        
        while (enemyHealth >= 0)
        {
            enemyHealth--;
            if (enemyHealth % 10 == 0)
            {
                Debug.Log($"Der Gegner besitzt noch {enemyHealth} Leben.");
            }
        }
    }
}