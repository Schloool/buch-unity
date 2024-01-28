using UnityEngine;

public class ExplicitInterfaceTest : MonoBehaviour
{
    private void Start()
    {
        IMethodInterface methodInterface = new MethodClass();
        methodInterface.TestMethod();

        MethodClass methodClass = new MethodClass();
        (methodClass as IMethodInterface).TestMethod();
    }
}