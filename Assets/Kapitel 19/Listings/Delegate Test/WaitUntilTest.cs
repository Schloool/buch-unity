using System.Collections;
using UnityEngine;

public class WaitUntilTest : MonoBehaviour
{
    private IEnumerator Start()
    {
        Debug.Log("Klicke mit der Maus!");
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        Debug.Log("Maus geklickt!");
    }
}