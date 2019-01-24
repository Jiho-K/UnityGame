using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickmanScript : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    public bool moving = false;
    public bool jumping = false;
    private float speedBoost = 0;
    public bool wallJump = false;
    private GameObject platform;
    //public bool slideDownWall = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -1);
        platform = GameObject.Find("jumpPlatform1");
    }



    void FixedUpdate()
    {
        if (Input.GetKey("a")&& !wallJump)
        {
            //float horizontal = Input.GetAxis("Horizontal");
            //float vertical = Input.GetAxis("Vertical");
            //Vector2 vector = new Vector2(horizontal, vertical);

            if (rb.velocity.x > 0.5)
                speedBoost = 0;

            speedBoost += Time.deltaTime;
            Vector2 changeVelocity = rb.velocity;
            //Debug.Log(changeVelocity);
            changeVelocity.x = -5* speedBoost;
            if (changeVelocity.x < -3)
                changeVelocity.x = -3;
            rb.velocity = changeVelocity;
            moving = true;

        }
        else if (Input.GetKey("d") && !wallJump)
        {
            if (rb.velocity.x < -0.5)
                speedBoost = 0;

            moving = true;
            speedBoost += Time.deltaTime;
            Vector2 changeVelocity = rb.velocity;
            //Debug.Log(changeVelocity);
            changeVelocity.x = 5*speedBoost;
            if (changeVelocity.x > 3)
                changeVelocity.x = 3;
            rb.velocity = changeVelocity;

        }
        else if ((Input.GetKeyUp("a") || Input.GetKeyUp("d")) && !jumping)
        {
            speedBoost = 0;
            moving = false;
            Vector2 changeVelocity = rb.velocity;
            changeVelocity.x = 0;
            rb.velocity = changeVelocity;

        }

        if (Input.GetKeyDown("space") && !jumping)
        {
            moving = true;
            Vector2 changeVelocity = rb.velocity;
            changeVelocity.y = 10;
            rb.velocity = changeVelocity;
            jumping = true;

        }

        if (wallJump)
        {
            speedBoost = 0;
        }


        if (Input.GetKey("a") && wallJump && rb.velocity.x < 0 && rb.velocity.x > -3)
        {
            speedBoost += Time.deltaTime;
            Vector2 changeVelocity = rb.velocity;
            changeVelocity.x = speedBoost * -10 + rb.velocity.x;
            if (changeVelocity.x < -3)
                changeVelocity.x = -3;
            rb.velocity = changeVelocity;
        }

        if (Input.GetKey("d") && wallJump)
        {
            speedBoost += Time.deltaTime;
            Vector2 changeVelocity = rb.velocity;
            changeVelocity.x = speedBoost * 10 + rb.velocity.x;
            if (changeVelocity.x > 3)
                changeVelocity.x = 3;
            rb.velocity = changeVelocity;
        }

        if(rb.velocity.x < 0)
        {
            gameObject.transform.localScale = new Vector3(-0.5f, 0.5f, 1);
        }

        if (rb.velocity.x > 0)
        {
            gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 1);
        }

    }

    

}
