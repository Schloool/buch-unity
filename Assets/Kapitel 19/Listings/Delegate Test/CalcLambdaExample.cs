using System;
using UnityEngine;

public class CalcLambdaExample : MonoBehaviour
{
    public delegate int NumberDelegate(int a, int b);
    
    private void Start()
    {
        Func<int, int, int> testDelegate = (a, b) => a + b;
        Debug.Log(testDelegate(5, 5));
        
        testDelegate = (a, b) => a - b;
        Debug.Log(testDelegate(5, 5));
    }
}