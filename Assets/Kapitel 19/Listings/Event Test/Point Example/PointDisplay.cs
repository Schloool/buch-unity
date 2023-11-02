using TMPro;
using UnityEngine;

public class PointDisplay : MonoBehaviour
{
    private TMP_Text pointText;
    private PointCounter pointCounter;

    private void Start()
    {
        pointText = GetComponent<TMP_Text>();
        pointCounter = FindObjectOfType<PointCounter>();
        pointCounter.OnUpdatePoints += HandlePointUpdate;
    }

    private void OnDestroy()
    {
        pointCounter.OnUpdatePoints -= HandlePointUpdate;
    }

    private void HandlePointUpdate(int points)
    {
        pointText.text = points.ToString();
    }
}