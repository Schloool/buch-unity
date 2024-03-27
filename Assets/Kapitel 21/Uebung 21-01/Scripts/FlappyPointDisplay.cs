using TMPro;
using UnityEngine;

/// <summary>
/// Enthält die Anzeigelogik für die bisher im Spiel erzielten Punkte.
/// </summary>
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

    /// <summary>
    /// Aktualisiert den hinterlegten Text mit einem neuen Punktzahl-Wert.
    /// </summary>
    private void HandlePointChange(int points)
    {
        text.text = points.ToString();
    }
}