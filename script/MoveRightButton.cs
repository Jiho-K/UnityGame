using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class MoveRightButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public stickmanScript stickman;
    public Button rightButton;
    private bool isPressed;

    // Start is called before the first frame update
    void Start()
    {
        GameObject stickmanSprite = GameObject.Find("stickman");
        stickman = stickmanSprite.GetComponent<stickmanScript>();
        Destroy(this);
        //remember to get rid of this line of code to make the buttons work


    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //rightButton.onClick.AddListener(MoveRight);
        //Debug.Log(isPressed);
        
        if (isPressed)
        {
            //Debug.Log(true);
            stickman.moving = true;
            Vector2 changeVelocity = stickman.rb.velocity;
            changeVelocity.x = 2;
            stickman.rb.velocity = changeVelocity;
        }
        else if (!isPressed && !stickman.moving)
        {
            //Debug.Log(false);
            stickman.moving = false;
            Vector2 changeVelocity = stickman.rb.velocity;
            changeVelocity.x = 0;
            stickman.rb.velocity = changeVelocity;
        }

    }

    /*void MoveRight()
    {
        if (!stickman.jumping)
        {
            //Debug.Log("true");
            stickman.moving = true;
            Vector2 changeVelocity = stickman.rb.velocity;
            changeVelocity.x = 2;
            stickman.rb.velocity = changeVelocity;
        }

    }*/

/*public void OnPointerDown(PointerEventData data)
{
    //stickman.moving = true;
    //Vector2 changeVelocity = stickman.rb.velocity;
    //changeVelocity.x = 2;
    //stickman.rb.velocity = changeVelocity;
    isPressed = true;
}


public void OnPointerUp(PointerEventData data)
{
    //stickman.moving = false;
    //Vector2 changeVelocity = stickman.rb.velocity;
    //changeVelocity.x = 0;
    //stickman.rb.velocity = changeVelocity;
    isPressed = false;

}*/
   public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        isPressed = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isPressed = false;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }

}


    /*
public class MoveRightButton : MonoBehaviour
{
    public stickmanScript stickman;
    public Button myButton;
    private bool isClicked = false;

    // Start is called before the first frame update
    void Start()
    {
        GameObject stickmanSprite = GameObject.Find("stickman");
        stickman = stickmanSprite.GetComponent<stickmanScript>();


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myButton.onClick.AddListener(Clicked);
    }

    void Clicked()
    {
        if (!stickman.jumping)
        {
            stickman.moving = true;
            Vector2 changeVelocity = stickman.rb.velocity;
            changeVelocity.x = 2;
            stickman.rb.velocity = changeVelocity;
        }

    }
}
*/