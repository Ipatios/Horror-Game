using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    // message prompted to the player when looking
    // an interactable object
    public string prompt;

    // this function will be called from our player script
    public void BaseInteract(){
        Interact();
    }
    
    /*
    - virtual：This method can be override by its sub classes

    -protected：This method can be only accessed by the class itself，
     or can be accessed by the inherited class，
     it cannot be accessed directly through the sub class instance
    */
    protected virtual void Interact(){
        // just a template to be overridden by our subclass
        // no code here
    }
}


/*
              *************************************
              helpfull info about the whole pattern
              *************************************

https://dotnettutorials.net/lesson/template-method-design-pattern/

*/