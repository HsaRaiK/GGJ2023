using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector3 target; // the target position to move the platform towards
    public float speed; // the speed at which the platform moves

    private Vector3 startPos; // the starting position of the platform

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(startPos, target, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
