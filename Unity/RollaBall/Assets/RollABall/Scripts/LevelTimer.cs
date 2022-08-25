using System.Collections;
using System.Collections.Generic;
using UnityEngine;                      // for default
using UnityEngine.UI;                   // for UI Text
using UnityEngine.SceneManagement;      // for SceneManager

using TMPro;                            // for TextMeshPro

public class LevelTimer : MonoBehaviour
{
    // Seconds
    public int timeLimit = 120;

    // public TMP_Text timerText;
    public Text timerText;

    private float timeElapsed = 0.0f;

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        // calculate time remaining
        int timeRemaining = timeLimit - (int)timeElapsed;
        if (timeRemaining < 0)
        {
            // ensure time doesn't go below zero
            timeRemaining = 0;

            SceneManager.LoadScene(0);
        }

        int minutesLeft = timeRemaining / 60;
        int secondsLeft = timeRemaining % 60;

        // update the UI
        timerText.text = minutesLeft.ToString("00") + ":" + secondsLeft.ToString("00");
    }
}