using System;
using UnityEngine;

/// <summary>
/// Script für eine Zielscheibe, die durch Projektile abgeschossen werden kann.
/// </summary>
public class ShooterTarget : MonoBehaviour
{
    public event Action<ShooterTarget> OnHit;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<ShooterBullet>() == null) return;

        OnHit?.Invoke(this);
        Destroy(gameObject);
    }
}