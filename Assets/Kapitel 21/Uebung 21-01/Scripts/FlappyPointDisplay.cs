using TMPro;
using UnityEngine;

public class FlappyPointDisplay : MonoBehaviour
{
    private TMP_Text text;
    private FlappyPointHandler pointHandler;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
        
        pointHandler = FindObjectOfType<FlappyPointHandler>();
        pointHandler.OnChangePoints += HandlePointChange;
    }

    private void OnDestroy()
    {
        pointHandler.OnChangePoints -= HandlePointChange;
    }

    private void HandlePointChange(int points)
    {
        text.text = points.ToString();
    }
}