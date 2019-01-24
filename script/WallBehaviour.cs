using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehaviour : MonoBehaviour { 

    public GameObject wall;
    public stickmanScript stickman;

    void OnTriggerStay2D(Collider2D collision)
    {
        //check the distance between stickman's position and the wall
        if (collision.name.Equals("stickman") && !stickman.wallJump)
        {
            float distance = wall.transform.position.x - stickman.transform.position.x;
            //Debug.Log(distance);
            if (distance < .4 && distance > -.4)
            {
                stickman.rb.velocity = new Vector2(0, -1);
                //stickman.slideDownWall = true;

                //change this condition to button in the future
                if ( Input.GetKeyDown("space") && !stickman.wallJump)
                {
                    stickman.rb.velocity = (new Vector2(-2, 10));
                    stickman.wallJump = true;

                }
            }
        }
    }
}
