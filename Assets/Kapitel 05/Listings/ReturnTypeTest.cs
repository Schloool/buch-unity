using UnityEngine;

public class ReturnTypeTest : MonoBehaviour
{
    void Start()
    {
        int x = GetNumber();	

        Debug.Log(GetNumber());

        GetNumber();
    } 

    int GetNumber()
    {
        return 10 + 10;
    }
}