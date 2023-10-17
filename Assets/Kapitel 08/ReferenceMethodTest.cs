using UnityEngine;

public class ReferenceMethodTest : MonoBehaviour
{
    private void Start()
    {
        Enemy enemy = new Enemy();
        enemy.speed = 10f;
        
        ChangeSpeed(enemy);
        
        Debug.Log(enemy.speed);
    }

    public void ChangeSpeed(Enemy a)
    {
        a.speed = 42f;
    }
}