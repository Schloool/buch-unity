using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Additive Cube Scene", LoadSceneMode.Additive);

            Scene scene = SceneManager.GetActiveScene();
            Debug.Log(scene.name);
            Debug.Log(scene.buildIndex);
            SceneManager.LoadSceneAsync("Additive Cube Scene", LoadSceneMode.Additive);
        }
    }
}
