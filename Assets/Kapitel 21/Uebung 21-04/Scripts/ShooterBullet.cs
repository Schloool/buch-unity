using UnityEngine;

/// <summary>
/// Script für eine Kugel, die im Spiel abgeschossen wurde.
///
/// Eine Kugel bewegt sich mit gleichbleibender Geschwindigkeit nach vorn.
/// </summary>
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