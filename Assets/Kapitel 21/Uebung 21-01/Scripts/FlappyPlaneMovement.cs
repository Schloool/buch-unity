using System;
using UnityEngine;

/// <summary>
/// Script für die Klick-Steuerung des Flugzeugs.
/// Enthält außerdem die Logik für das Zerbersten des Flugzeugs.
/// </summary>
public class FlappyPlaneMovement : MonoBehaviour
{
    public event Action OnDeath;
    
    [SerializeField] private float jumpForce;

    private Rigidbody2D rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;

        rigidbody.velocity = Vector3.zero;
        rigidbody.Sleep();
        rigidbody.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
    }
    
    /// <summary>
    /// Leitet die Zerstörungslogik des Flugzeugs ein.
    /// Diese Methode hat keine Wirkung, wenn das Flugzeug bereits zerstört wurde.
    /// </summary>
    public void Crash()
    {
        if (!rigidbody.simulated) return;
        
        OnDeath?.Invoke();
        rigidbody.simulated = false;
    }
}