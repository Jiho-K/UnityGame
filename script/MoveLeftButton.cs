using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class MoveLeftButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
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
            
            stickman.moving = true;
            Vector2 changeVelocity = stickman.rb.velocity;
            changeVelocity.x = -2;
            stickman.rb.velocity = changeVelocity;
            //Debug.Log(changeVelocity.x);
        }
        else if (!isPressed)
        {
            //Debug.Log(false);
            stickman.moving = false;
            Vector2 changeVelocity = stickman.rb.velocity;
            changeVelocity.x = 0;
            stickman.rb.velocity = changeVelocity;
        }

    }

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