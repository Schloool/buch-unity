using System;
using UnityEngine;

public class ShooterBullet : MonoBehaviour
{
    public Vector3 Direction { get; set; }
    
    [SerializeField] private float speed = 15f;

    private void Start()
    {
        Destroy(gameObject, 3f);
    }

    private void Update()
    {
        transform.position += Direction * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}