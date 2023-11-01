using System;
using UnityEngine;

public class ShooterTarget : MonoBehaviour
{
    public event Action<ShooterTarget> OnHit;
    
    public Transform PlayerTransform { get; set; }

    private void Update()
    {
        if (PlayerTransform == null) return;
        
        transform.LookAt(PlayerTransform);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<ShooterBullet>() == null) return;

        OnHit?.Invoke(this);
        Destroy(gameObject);
    }
}