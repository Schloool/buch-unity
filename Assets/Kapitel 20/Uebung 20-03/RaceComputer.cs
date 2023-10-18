﻿using UnityEngine;
using UnityEngine.AI;

public class RaceComputer : MonoBehaviour
{
    [SerializeField] private Transform goalPoint;

    private RaceCountdown countdown;
    
    private void Start()
    {
        countdown = FindObjectOfType<RaceCountdown>();
        countdown.OnChangeTimer += HandleCountdownUpdate;
    }

    private void HandleCountdownUpdate(int time)
    {
        if (time == 0)
        {
            GetComponent<NavMeshAgent>().SetDestination(goalPoint.position);
            countdown.OnChangeTimer -= HandleCountdownUpdate;
        }
    }
}