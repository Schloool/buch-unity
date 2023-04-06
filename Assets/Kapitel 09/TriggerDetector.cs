using UnityEngine;

public class TriggerDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        string collidedName = other.name;
        Debug.Log($"{collidedName} aktiviert Trigger {gameObject.name}");
    }
}