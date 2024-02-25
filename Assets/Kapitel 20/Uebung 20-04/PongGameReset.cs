using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PongGameReset : MonoBehaviour
{
    [SerializeField] private List<PongScoreZone> scoreZones;

    private void Awake()
    {
        scoreZones.ForEach(zone => zone.OnScore += HandleScoreChange);
    }

    private void OnDestroy()
    {
        scoreZones.ForEach(zone => zone.OnScore -= HandleScoreChange);
    }

    private void HandleScoreChange(int score)
    {
        if (score >= 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}