using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterAnimation : MonoBehaviour
{
    stickmanScript stickman;
    Animator anim;
    private int idleHash = Animator.StringToHash("still");
    private int movingHash = Animator.StringToHash("walkingAnim");

    void Start()
    {
        anim = GetComponent<Animator>();
        stickman = GameObject.Find("stickman").GetComponent<stickmanScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stickman.moving)
        {
            anim.SetTrigger("idle");
        } else if (!stickman.moving)
        {
            anim.SetTrigger(idleHash);
        }
    }
}
