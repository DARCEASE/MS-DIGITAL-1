using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PURPOSE: To bounce the player up on collision 
//USAGE: place this script on the platform itself 

public class PlatformBehavior : MonoBehaviour
{
    public float jumpForce = 10f; // wanna see how hard I can jump 
    public int bubbleCount; // counts how many times you collide with a bubble

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;

            }
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
