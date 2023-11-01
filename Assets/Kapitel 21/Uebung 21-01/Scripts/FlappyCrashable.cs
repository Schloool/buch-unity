using UnityEngine;

public class FlappyCrashable : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.TryGetComponent(out FlappyPlaneMovement movement)) return;
        
        movement.Crash();
    }
}