using UnityEngine;
using TMPro; // Import the TMPro namespace

public class LapCounter : MonoBehaviour
{
    public int totalLaps = 3;           // Total number of laps required to finish
    private int currentLap = 0;         // Current lap the player is on
    public TMP_Text LapCounterText;      // Reference to the TMP_Text

    void Start()
    {
        if (LapCounterText == null)
        {
            Debug.LogError("LapCounterText is not assigned in the Inspector!");
            return; // Exit if lapCounterText is not assigned
        }
        UpdateLapCounter();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            currentLap++;
            if (currentLap > totalLaps)
            {
                Debug.Log("Race Finished!");
            }
            else
            {
                UpdateLapCounter();
            }
        }
    }

    void UpdateLapCounter()
    {
        if (LapCounterText != null)
        {
            LapCounterText.text = "Lap: " + currentLap + "/" + totalLaps;
        }
        else
        {
            Debug.LogError("LapCounterText is null in UpdateLapCounter!");
        }
    }

}
