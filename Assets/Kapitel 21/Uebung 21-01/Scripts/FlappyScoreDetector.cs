using UnityEngine;

/// <summary>
/// Script für eine Trigger-Zone, durch die der Spieler beim Durchfliegen einen Punkt erhält.
/// </summary>
public class FlappyScoreDetector : MonoBehaviour
{
    private FlappyPointHandler pointHandler;

    private void Awake()
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