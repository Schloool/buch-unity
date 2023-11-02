using UnityEngine;

public class RefTest : MonoBehaviour
{
    private void Start()
    {
        int x = 10;
        Debug.Log(x);
        
        ChangeNumber(ref x);

        Debug.Log(x);
    }

    private void ChangeNumber(ref int number)
    {
        number = 20;
    }
}