using UnityEngine;

public class ParentClass
{
    public string attribute = "Feld";

    protected virtual void Method()
    {
        Debug.Log("Elternklasse");
    }
}