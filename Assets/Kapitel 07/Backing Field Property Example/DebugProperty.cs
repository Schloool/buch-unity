using UnityEngine;

public class DebugProperty
{
    private int _attribute;

    public int Attribute
    {
        get
        {
            Debug.Log("Lesen");
            return _attribute;
        }
        set
        {
            Debug.Log("Schreiben");
            _attribute = value;
        }
    }
}