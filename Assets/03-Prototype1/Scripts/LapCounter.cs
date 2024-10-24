using UnityEngine;
using UnityEngine.UI;

public class LapCounter : MonoBehaviour
{
    public int totalLaps = 3;           // Total number of laps required to finish
    private int currentLap = 0;         // Current lap the player is on
    public Text LapCounterText;          // Reference to the UI Text

    void Start()
    {
        // Initialize the lap counter text
        if (LapCounterText == null)
        {
            Debug.LogError("LapCounterText is not assigned in the Inspector!");
            return; // Exit if lapCounterText is not assigned
        }
        UpdateLapCounter();
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the player (marble) crosses a specific lap trigger
        if (other.CompareTag("Player"))
        {
            currentLap++;

            // If the current lap exceeds total laps, declare the race finished
            if (currentLap > totalLaps)
            {
                Debug.Log("Race Finished!");
            }
            else
            {
                // Update the lap counter display
                UpdateLapCounter();
            }
        }
    }

    void UpdateLapCounter()
    {
        if (LapCounterText != null) // Check if lapCounterText is not null
        {
            LapCounterText.text = "Lap: " + currentLap + "/" + totalLaps;
        }
        else
        {
            Debug.LogError("LapCounterText is null in UpdateLapCounter!");
        }
    }
}
