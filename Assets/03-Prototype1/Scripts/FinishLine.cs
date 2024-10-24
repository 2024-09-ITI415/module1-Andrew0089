using UnityEngine;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object entered trigger: " + other.gameObject.name); 

      
        if (other.CompareTag("Player"))
        {
            Debug.Log("Race Finished!");
         
        }
    }
}
