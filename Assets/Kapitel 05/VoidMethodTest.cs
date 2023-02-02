using UnityEngine;

public class VoidMethodTest : MonoBehaviour
{
    void Start()
    {
        MyVoidMethod();
    }

    void MyVoidMethod()
    {
        Debug.Log("Hallo!");
        Debug.Log("Ich bin eine void-Methode.");
    }
}
