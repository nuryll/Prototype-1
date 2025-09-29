using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float speed = 3f;        // Movement speed
    public float distance = 5f;     // How far left/right it moves

    private Vector3 startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // PingPong oscillates between 0 and distance
        float movement = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startPos + new Vector3(movement - distance / 2, 0, 0);


    }
}
