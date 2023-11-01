using System;
using UnityEngine;

public class PlatformGoal : MonoBehaviour
{
    public event Action OnReachGoal; 

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<PlatformPlayerMovement>() == null) return;

        OnReachGoal?.Invoke();
    }
}