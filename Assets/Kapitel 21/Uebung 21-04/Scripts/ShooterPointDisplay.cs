using TMPro;
using UnityEngine;

/// <summary>
/// Anzeigescript für die bisher erzielte Punktzahl.
/// </summary>
public class ShooterPointDisplay : MonoBehaviour
{
    private TMP_Text text;
    private ShooterPointCounter pointCounter;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
        pointCounter = FindObjectOfType<ShooterPointCounter>();
        pointCounter.OnChangePoints += HandleChangePoints;
    }

    /// <summary>
    /// Behandelt eine Änderung der Punktzahl, indem der Anzeigetext aktualisiert wird.
    /// </summary>
    private void HandleChangePoints(int points)
    {
        text.text = points.ToString();
    }
}