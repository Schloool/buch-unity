using UnityEngine;

public class DebugPropertyTest : MonoBehaviour
{
    private void Start()
    {
        DebugProperty property = new DebugProperty();

        property.Attribute = 42;
        int value = property.Attribute;

        property.Attribute++;
    }
}