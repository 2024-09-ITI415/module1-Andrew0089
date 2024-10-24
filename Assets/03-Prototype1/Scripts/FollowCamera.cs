using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform marble;      // Reference to the marble's transform
    public Vector3 offset;        // Offset between the marble and camera

    void Start()
    {
        // Initialize offset
        offset = transform.position - marble.position;
    }

    void LateUpdate()
    {
        // Update camera position to follow the marble with an offset
        transform.position = marble.position + offset;
    }
}
