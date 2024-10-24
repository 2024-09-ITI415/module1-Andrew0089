using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform marble;
    public Vector3 offset;        
    void Start()
    {
     
        offset = transform.position - marble.position;
    }

    void LateUpdate()
    {
       
        transform.position = marble.position + offset;
    }
}
