
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
    public float chanceToChangeDirection = 0.1f;
    // Rate at which Apples will be instantiated
    public float secondsBetweenAppleDrop = 1f;

    void Start()
    {
        // Dropping apples every second
    }

    void Update()
    {
        // Basic Movement
        // Changing Direction
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
    }
}

         
