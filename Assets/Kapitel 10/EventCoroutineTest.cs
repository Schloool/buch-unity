using System.Collections;
using UnityEngine;

public class EventCoroutineTest : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(1f);
        Debug.Log("Es wurde gewartet!");
    }
}