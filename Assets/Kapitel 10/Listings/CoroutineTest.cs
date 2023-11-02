using System.Collections;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    private IEnumerator MyCoroutine()
    {
        yield return null;
        Debug.Log("Die Coroutine ist vorbei.");
    }
}