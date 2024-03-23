using System;
using UnityEngine;

public class ShooterBullet : MonoBehaviour
{
    private Rigidbody rigidbody;
    
    [SerializeField] private float speed = 15f;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Destroy(gameObject, 3f);
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = transform.forward * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}