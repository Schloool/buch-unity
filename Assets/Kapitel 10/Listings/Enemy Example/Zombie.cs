using UnityEngine;

public class Zombie : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
    
    public void PrintSpeed()
    {
        Debug.Log($"Ich laufe mit der Geschwindigkeit {speed}.");
    }
}
