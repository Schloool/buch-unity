using UnityEngine;

public class ParentClass
{
    public string attribute = "Attribut";

    protected virtual void Method()
    {
        Debug.Log("Elternklasse");
    }
}