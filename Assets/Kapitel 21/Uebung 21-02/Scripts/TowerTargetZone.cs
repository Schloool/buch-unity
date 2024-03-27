using UnityEngine;

/// <summary>
/// Repräsentiert über einen Trigger die Zone, in die ein Gegner gelangen muss, damit dem Spieler Schaden zugefügt wird.
/// </summary>
public class TowerTargetZone : MonoBehaviour
{
    private TowerPlayerHealth playerHealth;

    private void Awake()
    {
        playerHealth = FindObjectOfType<TowerPlayerHealth>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.TryGetComponent(out TowerEnemy enemy)) return;
        
        playerHealth.Damage(enemy.Type.damage);
        enemy.Kill();
    }
}