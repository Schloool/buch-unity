using UnityEngine;

public class PongWall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.TryGetComponent(out PongBall ball))
        {
            float newYDirection = ball.CurrentDirection.y > 0f ? -1f : 1f;
            ball.CurrentDirection = new Vector3(ball.CurrentDirection.x, ball.GetRandomYVelocity() * newYDirection);
        }
    }
}