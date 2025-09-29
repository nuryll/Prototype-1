using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;   // Reference to the player (car)
    public Vector3 offset = new Vector3(0, 5, -12);  // Camera offset relative to car

    void LateUpdate()
    {
        // Position camera relative to player's rotation
        transform.position = player.position + player.rotation * offset;

        // Make camera always look at the car
        transform.LookAt(player);
    }
}

