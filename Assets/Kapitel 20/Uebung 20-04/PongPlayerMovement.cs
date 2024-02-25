using UnityEngine;

public class PongPlayerMovement : MonoBehaviour
{
    private const float MinY = -3f;
    private const float MaxY = 3f;
    
    [SerializeField] private float speed;
    [SerializeField] private KeyCode moveUpKey;
    [SerializeField] private KeyCode moveDownKey;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.TryGetComponent(out PongBall ball))
        {
            ball.speed *= 1.05f;
            ball.CurrentDirection = new Vector3(-ball.CurrentDirection.x, ball.CurrentDirection.y);
        }
    }
    
    private void Update()
    {
        float verticalInput = GetVerticalInput();
        float oldY = transform.position.y;
        float newY = Mathf.Clamp(oldY + verticalInput * speed * Time.deltaTime, MinY, MaxY);
        transform.position = new Vector2(transform.position.x, newY);
    }

    private float GetVerticalInput()
    {
        if (Input.GetKey(moveUpKey)) return 1f;
        if (Input.GetKey(moveDownKey)) return -1f;

        return 0f;
    }
}