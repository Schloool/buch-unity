using UnityEngine;

public class InterfaceTest : MonoBehaviour
{
    private void Start()
    {
        MyClass myClass = new MyClass();
        myClass.InterfaceTest();
        myClass.ClassTest();

        IMyInterface myInterface = new MyClass();
        myInterface.InterfaceTest();
    }
}