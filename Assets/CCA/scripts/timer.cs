using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText; // Drag your TimerText UI element here in the Inspector
    private float elapsedTime = 0f; // Tracks the time elapsed
    private bool isRunning = true; // Controls whether the timer is active

    void Update()
    {
        if (isRunning)
        {
            elapsedTime += Time.deltaTime; // Increment time
            UpdateTimerUI(); // Update the text display
        }
    }

    private void UpdateTimerUI()
    {
        // Format the time as mm:ss
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);
        timerText.text = $"{minutes:00}:{seconds:00}";
    }

    public void StopTimer(string specialCon)
    {
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);
        isRunning = false; // Stop the timer
        switch (specialCon)
        {
            case "Finish":

                timerText.text = $"you have finished with a time of: {minutes:00}:{seconds:00}";
                break;

            case "crash":

                timerText.text = $"you have failed with a time of: {minutes:00}:{seconds:00}";
                break;

            default:
                Debug.Log("no matching timer specialCon");
                break;
        }
        
    }

        public void StartTimer()
    {
        isRunning = true; // Resume the timer, unused
    }

    public float GetElapsedTime()
    {
        return elapsedTime; // Get the current elapsed time, unused
    }
}