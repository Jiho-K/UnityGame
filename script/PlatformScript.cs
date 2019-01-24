using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    public stickmanScript stickman;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject stickmanSprite = GameObject.Find("stickman");
        stickman = stickmanSprite.GetComponent<stickmanScript>();
        
    }



    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("stickman"))
        {
            stickman.jumping = false;
            stickman.rb.velocity = new Vector2(0, 0);
            stickman.wallJump = false;
            
        }
    }
}
