using UnityEngine;

public class Collision2DTest : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log($"Kollision mit {col.gameObject.name}");
    }
}
