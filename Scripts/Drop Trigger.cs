using UnityEngine;

public class DropTrigger : MonoBehaviour
{
    [SerializeField] Dropper dropper;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            dropper.Drop();
        }
    }
}