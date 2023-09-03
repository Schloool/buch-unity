using System;
using UnityEngine;

public class DelegateLambdaTest
{
    public delegate void MyDelegate();

    private void Start()
    {
        MyDelegate testDelegate = () => Debug.Log("Hallo!");
        testDelegate();

        Action a = () => Debug.Log("Action ohne Parameter");
        Action<string> b = input => Debug.Log($"Aufruf mit {input}");
        Action<int, string> c = (num, text) => Debug.Log($"{num}, {text}");

        a();
        b("Test");
        c(42, "Hallo");
    }
}