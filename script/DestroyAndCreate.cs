using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAndCreate : MonoBehaviour
{
    public stickmanScript stickman;
    public GameObject item;
    private float yLocStep;
    public Vector2 stepVectorPosition;
    private Rigidbody2D rb;

    void Start()
    {
        GameObject stickmanObject = GameObject.Find("stickman");
        stickman = stickmanObject.GetComponent<stickmanScript>();
        
        yLocStep = item.transform.position.y;
        stepVectorPosition = item.transform.position;
        
    }

  
    //check if the person is falling down. if it is falling, enable collider on the platform.
    private void FixedUpdate()
    {
        if (stickman.rb.velocity.y < 0)
        {
            Physics2D.IgnoreCollision(stickman.GetComponent<Collider2D>(), item.GetComponent<Collider2D>(), false);
        }
    }

    void Update()
    {
        if(stickman.transform.position.y - 10 >= item.transform.position.y)
        {
            stepVectorPosition =  new Vector2(-4.45f, item.transform.position.y+25);
            item.transform.position = stepVectorPosition;
        }
    }

    

    //check when person collides with platform. When collision occurs, 2 cases.
    //1: stickman is not moving and the stickman is on top of the platform:
    //stickman is no longer jumping
    //2: stickman is jumping: do not collide with the platform. Temporarily remove the
    //physics 2D component and enable as it is falling in FixedUpdate
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("stickman"))
        {
            if (stickman.rb.velocity == rb.velocity)
            {
                stickman.jumping = false;
            }
            else if (stickman.rb.velocity.y > 0)
            {
                Physics2D.IgnoreCollision(stickman.GetComponent<Collider2D>(), item.GetComponent<Collider2D>());

            }
            
        }
        
    }
}
