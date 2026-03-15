using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    Rigidbody rb;
    Camera mainCamera;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        mainCamera = Camera.main;
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // Camera relative direction
        Vector3 camForward = mainCamera.transform.forward;
        Vector3 camRight = mainCamera.transform.right;
        camForward.y = 0f;
        camRight.y = 0f;
        camForward.Normalize();
        camRight.Normalize();

        // Move instantly at fixed speed
        Vector3 inputDirection = camForward * zInput + camRight * xInput;
        inputDirection = Vector3.ClampMagnitude(inputDirection, 1f);

        rb.MovePosition(rb.position + inputDirection * moveSpeed * Time.fixedDeltaTime);
    }
}