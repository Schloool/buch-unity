using UnityEngine;

public class RaceOverDisplay : MonoBehaviour
{
    [SerializeField] private GameObject winnerPanel;
    [SerializeField] private GameObject playerWinText;
    [SerializeField] private GameObject computerWinText;

    private bool isGameOver;
    private RaceGoal goal;

    private void Start()
    {
        isGameOver = false;
        goal = FindObjectOfType<RaceGoal>();
        goal.OnEnd += HandleGameOver;
    }

    private void OnDestroy()
    {
        goal.OnEnd -= HandleGameOver;
    }

    private void HandleGameOver(bool isPlayerWinner)
    {
        if (isGameOver) return;

        isGameOver = true;
        winnerPanel.SetActive(true);
        Destroy(isPlayerWinner ? computerWinText : playerWinText);
    }
}