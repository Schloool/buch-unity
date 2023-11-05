using UnityEngine;

public class Vector2Test : MonoBehaviour
{
    private void Start()
    {
        Vector2 vector2 = new Vector2(5f, 2f);
        Vector3 vector3 = vector2;
        Debug.Log(vector3);
    }
}