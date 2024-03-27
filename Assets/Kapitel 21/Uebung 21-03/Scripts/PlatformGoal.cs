using System;
using UnityEngine;

/// <summary>
/// Script für den Zielbereich, den der Spieler in der Scene erreichen muss.
/// </summary>
public class PlatformGoal : MonoBehaviour
{
    public event Action OnReachGoal; 

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<PlatformPlayerMovement>() == null) return;

        OnReachGoal?.Invoke();
    }
}