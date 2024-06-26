﻿using UnityEngine;

/// <summary>
/// Script für ein Projektil, das von einem Gegner verschossen wird.
/// </summary>
public class PlatformEnemyProjectile : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float rotationSpeed;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void Update()
    {
        transform.position += Vector3.left * movementSpeed * Time.deltaTime;
        transform.rotation *= Quaternion.Euler(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.TryGetComponent(out PlatformPlayerHealth playerHealth)) return;
        
        playerHealth.Damage();
        Destroy(gameObject);
    }
}