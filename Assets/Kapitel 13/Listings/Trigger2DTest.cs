using UnityEngine;

public class Trigger2DTest : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log($"Kollision mit {col.gameObject.name}");
    }
}
