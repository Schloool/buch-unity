using UnityEngine;

public class ValueMethodTest : MonoBehaviour
{
    private void Start()
    {
        int number = 10;
        ChangeNumber(number);
        
        Debug.Log(number);
    }

    public void ChangeNumber(int a)
    {
        a = 42;
    }
}