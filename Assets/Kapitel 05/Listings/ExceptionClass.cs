using System;
using UnityEngine;

public class ExceptionClass : MonoBehaviour
{
    private void Start()
    {
        try
        {
            RuntimeException();
        }
        catch (IndexOutOfRangeException)
        {
            Debug.Log("IndexOutOfRangeException abgefangen!");
        }
        
        Debug.Log("Hallo!");

    }

    public void RuntimeException()
    {
        int[] myInts = { 1, 2, 5 };
        Debug.Log(myInts[3]);
    }
}