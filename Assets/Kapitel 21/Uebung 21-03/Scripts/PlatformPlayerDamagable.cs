using UnityEngine;

public class PlatformPlayerDamagable : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.collider.TryGetComponent(out PlatformPlayerHealth playerHealth)) return;
        
        playerHealth.Damage();
    }
}