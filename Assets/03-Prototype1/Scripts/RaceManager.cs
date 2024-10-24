using UnityEngine;

public class RaceManager : MonoBehaviour
{
    public ResetBall ballReset;  
    public RaceTimer raceTimer;  

    void Start()
    {
        
        if (raceTimer != null)
        {
            raceTimer.StartTimer();
        }
    }

    void Update()
    {
    
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartRace();
        }
    }

    public void RestartRace()
    {
       
        ballReset.ResetBallPosition();

       
        if (raceTimer != null)
        {
            raceTimer.ResetTimer();
        }

        Debug.Log("Race Restarted!");
    }
}
