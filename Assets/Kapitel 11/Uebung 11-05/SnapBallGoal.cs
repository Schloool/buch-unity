﻿using UnityEngine;

public class SnapBallGoal : MonoBehaviour
{
    private SnapBallGameHandler snapBallGameHandler;
    private SnapBallShot snapBallShot;

    private void Awake()
    {
        snapBallGameHandler = FindObjectOfType<SnapBallGameHandler>();
        snapBallShot = FindObjectOfType<SnapBallShot>();
    }

    private void OnTriggerEnter(Collider other)
    {
        snapBallGameHandler.AddPoint();
        snapBallShot.StopLoseCoroutine();
    }
}