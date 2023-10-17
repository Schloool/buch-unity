using UnityEngine;

public class Mammal
{
    private float speed;

    public Mammal(float speed)
    {
        this.speed = speed;
    }

    public void Move()
    {
        Debug.Log($"Bewegung mit Geschwindigkeit {speed}.");
    }
}