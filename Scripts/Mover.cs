using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float acceleration = 5f;
    [SerializeField] float deceleration = 8f;

    Rigidbody rb;
    Vector3 currentSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
        Vector3 InputDirection = transform.right * xInput + transform.forward * zInput;
        InputDirection = Vector3.ClampMagnitude(InputDirection, 1f);
        Vector3 targetSpeed = InputDirection * moveSpeed;
        float Speed = InputDirection.magnitude > 0 ? acceleration : deceleration;
        currentSpeed = Vector3.MoveTowards(currentSpeed, targetSpeed, Speed * Time.fixedDeltaTime);
        rb.MovePosition(rb.position + currentSpeed * Time.fixedDeltaTime);
    }
}