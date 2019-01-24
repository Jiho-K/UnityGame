using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpButtonScript : MonoBehaviour
{
    public stickmanScript stickman;
    public Button myButton;

    // Start is called before the first frame update
    void Start()
    {
        GameObject stickmanSprite = GameObject.Find("stickman");
        stickman = stickmanSprite.GetComponent<stickmanScript>();
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myButton.onClick.AddListener(MyFunction);
    }

    void MyFunction()
    {
        if (!stickman.jumping)
        {
            //Debug.Log("true");
            stickman.moving = true;
            Vector2 changeVelocity = stickman.rb.velocity;
            changeVelocity.y = 10;
            stickman.rb.velocity = changeVelocity;
            stickman.jumping = true;
        }
        
    }
}
