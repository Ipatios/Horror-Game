using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    private Animator doorAnimation;
    private bool doorOpen = false;
    private void Awake() {
        doorAnimation = gameObject.GetComponent<Animator>();
    }
   protected override void Interact()
    {
        if (!doorOpen)
        {
            doorAnimation.Play("OpenDoor", 0, 0.0f);
            doorOpen = true;
        }else{
            doorAnimation.Play("CloseDoor", 0, 0.0f);
            doorOpen = false;
        }
    }
}

/*
**********************************************
                animation help
**********************************************
https://www.youtube.com/watch?v=K9jnIPnsQ_w

*/
