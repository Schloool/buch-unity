using UnityEngine;

public class OutTest : MonoBehaviour
{
    private void Start()
    {
        OutNumber(out int a);
        
        Debug.Log(a);
    }

    private void OutNumber(out int number)
    {
        number = 20;
    }
}