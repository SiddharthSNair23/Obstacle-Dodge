using UnityEngine;

public class Flyer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float moveSpeed = 1f;
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
        if(transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }

    void FlyerPosition()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * moveSpeed);
    }
}
