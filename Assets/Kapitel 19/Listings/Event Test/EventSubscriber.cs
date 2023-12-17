using UnityEngine;

public class EventSubscriber : MonoBehaviour
{
    private EventSender eventSender;
    
    private void Awake()
    {
        eventSender = FindObjectOfType<EventSender>();
        eventSender.MyEvent += HandleEvent;
    }

    private void OnDestroy()
    {
        eventSender.MyEvent -= HandleEvent;
    }

    private void HandleEvent()
    {
        Debug.Log("Event wurde ausgelöst!");
    }
}