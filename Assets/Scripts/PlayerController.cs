using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        // Reset input values each frame
        horizontalInput = 0f;
        forwardInput = 0f;

        // Forward & backward
        if (Input.GetKey(KeyCode.T))
        {
            forwardInput = 1f;   // move forward
        }
        else if (Input.GetKey(KeyCode.G))
        {
            forwardInput = -1f;  // move backward
        }

        // Turning left & right
        if (Input.GetKey(KeyCode.F))
        {
            horizontalInput = -1f; // turn left
        }
        else if (Input.GetKey(KeyCode.H))
        {
            horizontalInput = 1f;  // turn right
        }

        // Move the car
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}

