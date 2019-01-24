using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatformVertical : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject platform;
    public Vector2 centrePlatformLocation;
    public Rigidbody2D rb;
    public float speed;
    private bool up;
    private stickmanScript stickman;

    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        centrePlatformLocation = platform.transform.position;
        up = true;
        stickman = GameObject.Find("stickman").GetComponent<stickmanScript>();
    }

    // Update is called once per frame
    
    void FixedUpdate()
    {
        if (platform.transform.position.y >= centrePlatformLocation.y +1 )
        {
            up = false;
        }
        else if(platform.transform.position.y <= centrePlatformLocation.y - 1)
        {
            up = true;
        }

        if (up)
        {
            rb.velocity = new Vector2(0, 1);
        } else
        {
            rb.velocity = new Vector2(0, -1);
        }
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("stickman"))
        {
            // set stickman velocity to the velocity of the platform!
            stickman.rb.velocity = rb.velocity;
            Debug.Log(true);
        }
    }
}
