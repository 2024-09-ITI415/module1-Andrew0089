using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _MainCamera : MonoBehaviour{
    static public GameObject POI;
    [Header("Set Dynamically")]
 public float camZ;
 void Awake(){
    camZ = this.transform.position.z;
 }   
}
void FixedUpdate (){
    if (POI == null) return; 
    Vector 3 destination = POI.transform.position;
    destination.z = camZ
    transform.position = destination;
}