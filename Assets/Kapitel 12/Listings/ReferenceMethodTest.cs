using UnityEngine;

public class ReferenceMethodTest : MonoBehaviour
{
    private void Start()
    {
        Enemy enemy = new Enemy();
        enemy.speed = 10f;
        
        ChangeSpeed(ref enemy);
        
        Debug.Log(enemy.speed);
    }

    public void ChangeSpeed(ref Enemy a)
    {
        a.speed = 42f;
        a = new Enemy();
        a.speed = 30f;
    }
}