using UnityEngine;

public class ConstraintTest<T> where T : MonoBehaviour
{
    public void Test(T component)
    {
        Debug.Log($"Name des Objekts: {component.gameObject.name}");
    }
}