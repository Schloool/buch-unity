using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsyncSceneCoroutine : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(LoadSceneRoutine());
        }
    }

    private IEnumerator LoadSceneRoutine()
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(0);
        asyncOperation.allowSceneActivation = false;
        
        while (asyncOperation.progress < 0.9f)
        {
            Debug.Log($"Abgeschlossen: {asyncOperation.progress * 100}%");
            yield return null;
        }

        Debug.Log("Scene wurde asynchron geladen!");
        asyncOperation.allowSceneActivation = true;
    }
}