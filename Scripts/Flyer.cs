using UnityEngine;

public class Flyer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float moveSpeed = 10f;
    Vector3 playerPosition;
    
    void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        FlyerPosition();
        DestroyWhenYouReach();
    }

    void DestroyWhenYouReach()
    {
        // Fixed - distance check instead of exact position
        if(Vector3.Distance(transform.position, playerPosition) < 0.1f)
        {
            Destroy(gameObject);
        }
    }

    void FlyerPosition()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * moveSpeed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            // Change colour on hit
            GetComponent<Renderer>().material.color = Color.red;
            Destroy(gameObject, 0.2f);
        }
    }
}