using TMPro;
using UnityEngine;

public class PongScoreDisplay : MonoBehaviour
{
    [SerializeField] private PongScoreZone forZone;

    private TMP_Text text;
    
    private void Start()
    {
        text = GetComponent<TMP_Text>();
        forZone.OnScore += HandleScoreChange;
    }

    private void OnDestroy()
    {
        forZone.OnScore -= HandleScoreChange;
    }

    private void HandleScoreChange(int score)
    {
        text.text = score.ToString();
    }
}