using UnityEngine;
using UnityEngine.SceneManagement;

public class MarbleRestartTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}