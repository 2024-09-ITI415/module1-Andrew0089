
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    // Prefab for instantiating apples
    public GameObject ApplePrefab;
    // Speed at which the AppleTree moves
    public float speed = 10f;
    // Distance where AppleTree turns around
    public float leftAndRightEdge = 20f;
    // Chance that the AppleTree will change direction
    public float chanceToChangeDirection = 0.02f;
    // Rate at which Apples will be instantiated
    public float secondsBetweenAppleDrop = 1f;

    void Start()
    {
        // Dropping apples every second
        Invoke("DropApple", 2f);
    }
    void DropApple()
    {
        GameObject apple = Instantiate(ApplePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrop);
    }

    void Update()
    {
        // Basic Movement
      
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        // Changing Direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); // Move
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); // Move
        }
    }

    void FixedUpdate()
{
    // Changing Direction Randomly is now t
    if (Random.value < chanceToChangeDirection)
    { 
            speed *= -1; // Change direction
        }
    }
}
