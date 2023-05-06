using UnityEngine;

public class SimpleEnemy : MonoBehaviour
{
    [SerializeField] private float speed;
    
    public void PrintSpeed()
    {
        Debug.Log($"Ich habe die Geschwindigkeit {speed}.");
    }
}
