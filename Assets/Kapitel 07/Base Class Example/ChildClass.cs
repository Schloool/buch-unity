using UnityEngine;

public class ChildClass : ParentClass
{
    protected override void Method()
    {
        base.Method();
        Debug.Log("Kindklasse");
    }
}