using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float dropSpeed = 10f;

    MeshRenderer myMeshRenderer;
    Rigidbody myRigidbody;

    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();
        myMeshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

    public void Drop()
    {
        myMeshRenderer.enabled = true;
        myRigidbody.useGravity = true;
        myRigidbody.AddForce(Vector3.down * dropSpeed, ForceMode.Impulse);
    }
}