using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PongGameReset : MonoBehaviour
{
    private PongScoreZone[] scoreZones;

    private void Start()
    {
        scoreZones = FindObjectsOfType<PongScoreZone>();
        scoreZones.ToList().ForEach(zone => zone.OnScore += HandleScoreChange);
    }

    private void OnDestroy()
    {
        scoreZones.ToList().ForEach(zone => zone.OnScore -= HandleScoreChange);
    }

    private void HandleScoreChange(int score)
    {
        if (score >= 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}