using UnityEngine;

public class CompareTest : MonoBehaviour
{
    void Start()
    {
        Enemy a = new Enemy();
        a.speed = 10f;
        
        Enemy b = new Enemy();
        b.speed = 10f;
        
        Debug.Log(a == b);
    }
}
