﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class SnapBallGameHandler : MonoBehaviour
{
    [SerializeField] private Rigidbody ball;
    [SerializeField] private GameObject goalObject;
    [SerializeField] private float minGoalX;
    [SerializeField] private float maxGoalX;

    private string highscoreKey = "highscore";
    private Vector3 defaultBallPosition;
    private int score;
    private int failedShots;

    private void Awake()
    {
        defaultBallPosition = ball.transform.position;
    }

    private void Start()
    {
        ResetRound();
    }

    public void ResetRound()
    {
        ball.transform.position = defaultBallPosition;
        ball.velocity = Vector3.zero;
        ball.Sleep();
        
        float randomX = Random.Range(minGoalX, maxGoalX);
        Vector3 goalPos = goalObject.transform.position;
        goalObject.transform.position = new Vector3(randomX, goalPos.y, goalPos.z);
    }

    public void AddPoint()
    {
        score++;
        Debug.Log($"Punktzahl: {score}");
        ResetRound();
    }

    public void FailRound()
    {
        failedShots++;
        Debug.Log($"Fehlversuche: {failedShots}");

        if (failedShots < 3)
        {
            ResetRound();
            return;
        }
        
        int currentHighscore = PlayerPrefs.GetInt(highscoreKey, 0);
        if (score > currentHighscore)
        {
            PlayerPrefs.SetInt(highscoreKey, score);
            currentHighscore = score;
        }

        Debug.Log($"Highscore: {currentHighscore}");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}