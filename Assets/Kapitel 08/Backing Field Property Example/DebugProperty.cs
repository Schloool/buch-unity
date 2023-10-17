using UnityEngine;

public class DebugProperty
{
    private int attribute;

    public int Attribute
    {
        get
        {
            Debug.Log("Lesen");
            return attribute;
        }
        set
        {
            Debug.Log("Schreiben");
            attribute = value;
        }
    }
}