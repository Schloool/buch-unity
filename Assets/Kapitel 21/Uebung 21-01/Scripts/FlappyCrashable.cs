using UnityEngine;

/// <summary>
/// Script, das an Collider gehangen werden kann, die bei einer Berührung das Flugzeug zerstören sollen.
/// </summary>
public class FlappyCrashable : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.gameObject.TryGetComponent(out FlappyPlaneMovement movement)) return;
        
        movement.Crash();
    }
}