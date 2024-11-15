using UnityEngine;

public class Saw : MonoBehaviour
{
    public enum Side
    {
        Left,
        Right
    }
    public Side moveSide = Side.Right;
    public float speed; 
    public float distance;
    public float rotationSpeed;
    private Vector2 startPosition;
    private Vector2 endPosition;
    private float journeyLength;

    void Start()
    {
        startPosition = transform.position;
        endPosition = startPosition + (moveSide == Side.Right ? new Vector2(distance, 0) : new Vector2(-distance, 0));
        journeyLength = Vector2.Distance(startPosition, endPosition);
    }

    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, journeyLength);
        transform.position = startPosition + (moveSide == Side.Right ? new Vector2(movement, 0) : new Vector2(-movement, 0));
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
