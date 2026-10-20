using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Import UI namespace

public class Timer : MonoBehaviour
{
    public float gameTime = 60f; // Total time for the game in seconds
    private bool timerActive = true; // Controls if the timer is running
    public Text timeText; // Reference to the UI Text component

    // Start is called before the first frame update
    void Start()
    {
        // Optionally, you can initialize the timer here
        if (timeText != null)
        {
            timeText.text = "Time left: " + gameTime; // Initialize timer display
        }
        Debug.Log("Timer started! Time left: " + gameTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive)
        {
            // Decrease the game time
            gameTime -= Time.deltaTime;

            // Update the timer text in UI
            if (timeText != null)
            {
                timeText.text = "Time left: " + Mathf.Ceil(gameTime); // Display remaining time
            }

            // Check if time has run out
            if (gameTime <= 0)
            {
                timerActive = false; // Stop the timer
                if (timeText != null)
                {
                    timeText.text = "Time's up!"; // Update text to show time's up
                }
                Debug.Log("Time's up!"); // Log message for timer completion
                // Optionally, you can add code here to handle what happens when time is up
            }
        }
    }
}
