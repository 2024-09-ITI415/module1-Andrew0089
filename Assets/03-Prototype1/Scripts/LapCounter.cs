using UnityEngine;
using TMPro;

public class LapCounter : MonoBehaviour
{
    public int totalLaps = 3;             
    private int currentLap = 0;           
    public TMP_Text lapCounterText;          
    private bool hasCrossedFinishLine = false; 

    void Start()
    {
        
        UpdateLapCounter();
    }

    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player") && !hasCrossedFinishLine)
        {
            currentLap++;
            hasCrossedFinishLine = true; 

          
            if (currentLap > totalLaps)
            {
                Debug.Log("Race Finished!");
                currentLap = totalLaps; 
            }

            
            UpdateLapCounter();
        }
    }

    void OnTriggerExit(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            hasCrossedFinishLine = false; 
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
