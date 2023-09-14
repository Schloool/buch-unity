using System;
using UnityEngine;

public class EventSender : MonoBehaviour
{
    public event Action MyEvent;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MyEvent?.Invoke();
        }
    }
}