using UnityEngine;

public class FlappyScoreDetector : MonoBehaviour
{
    private FlappyPointHandler pointHandler;

    private void Start()
    {
        pointHandler = FindObjectOfType<FlappyPointHandler>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.GetComponent<FlappyPlaneMovement>() == null) return;
        
        pointHandler.AddPoint();
        Destroy(gameObject);
    }
}