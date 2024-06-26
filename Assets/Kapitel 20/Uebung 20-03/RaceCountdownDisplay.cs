﻿using System;
using TMPro;
using UnityEngine;

public class RaceCountdownDisplay : MonoBehaviour
{
    private TMP_Text countdownText;
    private RaceCountdown countdown;
    
    private void Awake()
    {
        countdownText = GetComponent<TMP_Text>();
        countdown = FindObjectOfType<RaceCountdown>();

        countdown.OnChangeTimer += UpdateText;
    }

    private void OnDestroy()
    {
        countdown.OnChangeTimer -= UpdateText;
    }

    private void UpdateText(int time)
    {
        countdownText.text = time.ToString();

        if (time == 0)
        {
            countdownText.enabled = false;
            countdown.OnChangeTimer -= UpdateText;
        }
    }
}