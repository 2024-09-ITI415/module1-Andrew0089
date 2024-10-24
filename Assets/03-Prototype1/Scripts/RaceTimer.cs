using UnityEngine;
using TMPro;

public class RaceTimer : MonoBehaviour
{
    private float timer;          // Holds the elapsed time
    private bool isTiming;        // Indicates whether the timer is running
    public TMP_Text timerText;    // Reference to the TextMeshPro UI element

    void Start()
    {
        ResetTimer(); // Initialize the timer
    }

    void Update()
    {
        if (isTiming)
        {
            timer += Time.deltaTime; 
            UpdateTimerText();      
            Debug.Log("Timer: " + timer); 
        }
    }

    public void StartTimer()
    {
        isTiming = true;
        timer = 0f;
        Debug.Log("Timer Started!"); 
    }

    public void StopTimer()
    {
        isTiming = false; 
        Debug.Log("Timer Stopped!");
    }

    public float GetTime()
    {
        return timer; 
    }

    public void ResetTimer()
    {
        isTiming = false; 
        timer = 0f;      
        UpdateTimerText(); 
        Debug.Log("Timer Reset!"); 
    }

    private void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timer / 60); 
        int seconds = Mathf.FloorToInt(timer % 60);  
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        Debug.Log("Updated Timer Text: " + timerText.text); 
    }
}
