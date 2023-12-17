using System.Collections;
using UnityEngine;

public class PongBall : MonoBehaviour
{
    public float speed;

    private float defaultSpeed;
    private Vector3 defaultPosition;
    
    public Vector3 CurrentDirection { get; set; }

    private void Awake()
    {
        defaultSpeed = speed;
        defaultPosition = transform.position;
    }

    private void Start()
    {
        StartCoroutine(ResetBall());
    }

    private void Update()
    {
        transform.position += CurrentDirection.normalized * speed * Time.deltaTime;
    }

    public IEnumerator ResetBall()
    {
        speed = defaultSpeed;
        transform.position = defaultPosition;
        CurrentDirection = Vector3.zero;
        yield return new WaitForSeconds(1f);
        CurrentDirection = new Vector2(GetRandomDirection(), GetRandomYVelocity() * GetRandomDirection());
    }

    private float GetRandomDirection()
    {
        return Random.value >= 0.5f ? -1f : 1f;
    }

    public float GetRandomYVelocity()
    {
        return Random.Range(0.3f, 1f);
    }
}