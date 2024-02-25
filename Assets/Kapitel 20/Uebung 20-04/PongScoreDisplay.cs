using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

public class PongScoreDisplay : MonoBehaviour
{
    [SerializeField] private PongScoreZone zone;

    private TMP_Text text;
    
    private void Awake()
    {
        text = GetComponent<TMP_Text>();
        zone.OnScore += HandleScoreChange;
    }

    private void OnDestroy()
    {
        zone.OnScore -= HandleScoreChange;
    }

    private void HandleScoreChange(int score)
    {
        text.text = score.ToString();
    }
}