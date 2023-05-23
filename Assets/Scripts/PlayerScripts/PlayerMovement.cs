using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Gravity gravity;
    [SerializeField] private CharacterController controller;
    [SerializeField] private Input movementInput;
    private float walkSpeed = 3.5f;


    // Update is called once per frame
    void Update()
    {
        Vector3 moveDir = 
        transform.right * movementInput.GetMovementVectorNormalized().x + 
        transform.forward * movementInput.GetMovementVectorNormalized().y;
       

        controller.Move(moveDir * walkSpeed * Time.deltaTime);

        gravity.GetVelocity();

        controller.Move(gravity.GetVelocity() * Time.deltaTime);


    }

}



// https://www.youtube.com/watch?v=_QajrabyTJc&t=238s