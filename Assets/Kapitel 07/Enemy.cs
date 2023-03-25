using UnityEngine;

public class Enemy
{
    public float speed;

    public void Walk()
    {
        Debug.Log($"Ich laufe mit der Geschwindigkeit {speed}");
    }
}