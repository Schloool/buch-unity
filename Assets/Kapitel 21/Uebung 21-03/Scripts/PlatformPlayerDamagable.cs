using UnityEngine;

/// <summary>
/// Script, das an Collider gehangen werden kann, die dem Spieler beim Berühren Schaden zufügen sollen.
/// </summary>
public class PlatformPlayerDamagable : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (!col.collider.TryGetComponent(out PlatformPlayerHealth playerHealth)) return;
        
        playerHealth.Damage();
    }
}