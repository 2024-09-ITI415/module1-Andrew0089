
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    // Prefab for instantiating apples
    public GameObject applePrefab;
    // Speed at which the AppleTree moves
    public float speed = 1f;
    // Distance where AppleTree turns around
    public float leftAndRightEdge = 20f;
    // Chance that the AppleTree will change di
    public float chanceToChangeDirection
// Rate at which Apples will be instantiate
public float secondsBetweenAppleDrop
void Start()
    {
        // Dropping apples every second
    }
    void Update()
    {
// Basic Movement
// Changing Direction