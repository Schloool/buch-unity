using UnityEngine;

public class MethodClass : IMethodInterface
{
    void IMethodInterface.TestMethod()
    {
        Debug.Log("Test!");
    }
}