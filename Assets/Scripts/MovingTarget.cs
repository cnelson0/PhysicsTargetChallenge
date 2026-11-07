using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float moveRange = 3f;
    public Vector3 moveDirection = Vector3.right;

    private Rigidbody rb;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float offset = Mathf.PingPong(Time.time * moveSpeed, moveRange * 2f) - moveRange;
        Vector3 newPosition = startPosition + moveDirection.normalized * offset;

        if (rb != null)
            rb.MovePosition(newPosition);
        else
            transform.position = newPosition;
    }
}
