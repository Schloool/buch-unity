using System;
using UnityEngine;

public class PongScoreZone : MonoBehaviour
{
    public event Action<int> OnScore;

    private int score;
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.TryGetComponent(out PongBall ball))
        {
            OnScore?.Invoke(++score);
            StartCoroutine(ball.ResetBall());
        }
    }
}