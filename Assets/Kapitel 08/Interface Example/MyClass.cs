using UnityEngine;

public class MyClass : IMyInterface
{
    public void InterfaceTest()
    {
        Debug.Log("Interface");
    }

    public void ClassTest()
    {
        Debug.Log("Klasse");
    } 
}