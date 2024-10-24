using UnityEngine;
using TMPro; // For TextMeshPro

public class LapCounter : MonoBehaviour
{
    public int totalLaps = 3;               
    private int currentLap = 0;             
    public TMP_Text lapCounterText;       

    void Start()
    {
        
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
                currentLap = totalLaps; 
            }

            
            UpdateLapCounter();
        }
    }

    void UpdateLapCounter()
    {
        
        if (lapCounterText != null)
        {
            lapCounterText.text = "Lap: " + currentLap + "/" + totalLaps;
        }
    }
}
