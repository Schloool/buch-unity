using TMPro;
using UnityEngine;

public class ShooterPointDisplay : MonoBehaviour
{
    private TMP_Text text;
    private ShooterPointCounter pointCounter;

    private void Start()
    {
        text = GetComponent<TMP_Text>();
        pointCounter = FindObjectOfType<ShooterPointCounter>();
        pointCounter.OnChangePoints += HandleChangePoints;
    }

    private void HandleChangePoints(int points)
    {
        text.text = points.ToString();
    }
}