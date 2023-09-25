using UnityEngine;

public class ExceptionClass : MonoBehaviour
{
    private void Start()
    {
        RuntimeException();
        
    }

    public void RuntimeException()
    {
        int[] myInts = { 1, 2, 5 };
        Debug.Log(myInts[3]);
    }
}