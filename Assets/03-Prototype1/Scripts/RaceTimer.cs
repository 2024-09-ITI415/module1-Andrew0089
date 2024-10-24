using UnityEngine;
using TMPro;

public class RaceTimer : MonoBehaviour
{
    private float timer;          
    private bool isTiming;        
    public TMP_Text timerText;    

    void Start()
    {
        ResetTimer(); 
    }

    void Update()
    {
        if (isTiming)
        {
            timer += Time.deltaTime; 
            UpdateTimerText();       
        }
    }

    public void StartTimer()
    {
        isTiming = true; 
        timer = 0f;     
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
    }
}
