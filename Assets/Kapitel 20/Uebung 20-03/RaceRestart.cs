using UnityEngine;
using UnityEngine.SceneManagement;

public class RaceRestart : MonoBehaviour
{
    public void RestartRace()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}