using UnityEngine;

public class Playermovement: MonoBehaviour
{
    public float speed = 10f;    // Speed of the marble

    private Rigidbody rb;        // Reference to the Rigidbody component

    void Start()
    {
        // Get the Rigidbody component attached to the marble
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get input from the player
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create movement vector
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply force to the marble
        rb.AddForce(movement * speed);
    }
}
