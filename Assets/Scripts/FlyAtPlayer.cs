using UnityEditor.Experimental.GraphView;
using UnityEditor.Rendering;
using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    
    void OnEnable()
    {
        playerPosition = player.transform.position;
    }
    void Start()
    {
        
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
        DestroyWhenReached();
        
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);

        }
    }
    
    // void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.tag == "Ground")
    //     {
    //         Destroy(gameObject);
    //     }
    // }
}
