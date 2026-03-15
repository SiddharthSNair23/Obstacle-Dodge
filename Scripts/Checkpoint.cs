using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public static Vector3 playerPosition;

   void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerPosition = other.transform.position;
            Debug.Log("Checkpoint saved at: " + playerPosition);
        }
    }
}
