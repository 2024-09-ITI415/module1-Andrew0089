using UnityEngine;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Check if the player (marble) has reached the finish line
        if (other.CompareTag("Player"))
        {
            Debug.Log("Race Finished!");
            // Additional code to stop the marble or show race results can go here
        }
    }
}
