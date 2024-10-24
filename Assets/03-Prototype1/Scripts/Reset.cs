using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ResetBall : MonoBehaviour
{
    public Vector3 startingPosition;  
    public float fallThreshold = -10f;  

    private Rigidbody rb;

    void Start()
    {
        startingPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
       
        if (transform.position.y < fallThreshold)
        {
            ResetBallPosition();  
        }
    }

    public void ResetBallPosition()
    {
        
        transform.position = startingPosition;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        Debug.Log("Ball Reset to Starting Position!");
    }
}
