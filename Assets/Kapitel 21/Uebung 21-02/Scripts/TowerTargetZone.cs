using UnityEngine;

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