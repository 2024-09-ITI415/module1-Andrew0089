using UnityEngine;

public class RaceManager : MonoBehaviour
{
    public ResetBall ballReset;
    public RaceTimer raceTimer;

    void Start()
    {
        StartRace();
    }

    public void StartRace()
    {
        ballReset.ResetBallPosition(); 
        raceTimer.StartTimer(); 
        Debug.Log("Race Started!");
    }

    public void FinishRace(string playerName)
    {
        raceTimer.StopTimer(); 
        float finalTime = raceTimer.GetTime(); 
        Debug.Log("Race Finished! Time: " + finalTime);
    }

    public void RestartRace()
    {
        ballReset.ResetBallPosition();
        raceTimer.ResetTimer();
        StartRace();
        Debug.Log("Race Restarted!");
    }
}
