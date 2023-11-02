using UnityEngine;

public class DelegateTest : MonoBehaviour
{
    public delegate void MyDelegate();

    private void Start()
    {
        MyDelegate testDelegate = Hello;
        testDelegate();
    }

    private void Hello()
    {
        Debug.Log("Hallo!");
    }
}