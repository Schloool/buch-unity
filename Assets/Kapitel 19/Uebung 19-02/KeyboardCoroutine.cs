using System.Collections;
using UnityEngine;

public class KeyboardCoroutine : MonoBehaviour
{
    private IEnumerator Start()
    {
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.UpArrow));
        Debug.Log("Pfeiltaste hoch gedrückt!");

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.DownArrow));
        Debug.Log("Pfeiltaste runter gedrückt!");

        yield return new WaitWhile(() => Input.GetKey(KeyCode.DownArrow));
        Debug.Log("Pfeiltaste runter wieder losgelassen!");
    }
}
