using System.Collections;
using UnityEngine;

public class StopAllCoroutinesTest : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(MyUpdateCoroutine());
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
            Debug.Log("Leertaste! Coroutines werden beendet.");
            StopAllCoroutines();
        }
    }
}