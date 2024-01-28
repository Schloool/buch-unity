using System.Collections;
using UnityEngine;

public class StopCoroutineTest : MonoBehaviour
{
    private Coroutine coroutine;
    
    private void Start()
    {
       coroutine = StartCoroutine(MyUpdateCoroutine());
    }

    private IEnumerator MyUpdateCoroutine()
    {
        while (true)
        {
            yield return null;
            Debug.Log("Update wird ausgeführt.");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Leertaste! Coroutine wird beendet.");
            StopCoroutine(coroutine);
        }
    }
}