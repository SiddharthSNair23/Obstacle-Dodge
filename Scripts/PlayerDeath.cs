using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
        void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Hazard") || 
                other.gameObject.CompareTag("Hit"))
            {
                Die();
            }
        }
        public void Die()
        {
            rb.linearVelocity = Vector3.zero;
            transform.position = Checkpoint.playerPosition;
        }
}