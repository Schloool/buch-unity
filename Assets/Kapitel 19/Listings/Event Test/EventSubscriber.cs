using UnityEngine;

public class EventSubscriber : MonoBehaviour
{
    private EventSender eventSender;
    
    private void Start()
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