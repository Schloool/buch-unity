using UnityEngine;

public abstract class MyAbstractComponent : MonoBehaviour
{
    public string stringAttribute;

    private void Start()
    {
        Debug.Log(DoSomething());
    }

    public abstract string DoSomething();
}