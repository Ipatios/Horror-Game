using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : Interactable
{
    protected override void Interact()
    {
        Debug.Log("interacted with: "+gameObject.name);
    }
}
