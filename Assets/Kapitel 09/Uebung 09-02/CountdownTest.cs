using System.Collections;
using UnityEngine;

public class CountdownTest : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(CountdownCoroutine());
    }

    private IEnumerator CountdownCoroutine()
    {
        for (int i = 10; i >= 1; i--)
        {
            Debug.Log($"Noch {i} Sekunden...");
            yield return new WaitForSeconds(1f);
        }
        
        Debug.Log("Fertig!");
    }
}