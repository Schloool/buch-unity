using System;
using UnityEngine;

public class RaceGoal : MonoBehaviour
{
    public event Action<bool> OnEnd;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<RacePlayer>() != null)
        {
            OnEnd?.Invoke(true);
        }

        if (other.GetComponent<RaceComputer>() != null)
        {
            OnEnd?.Invoke(false);
        }
    }
}