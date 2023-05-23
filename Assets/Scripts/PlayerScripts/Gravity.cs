using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
  private Vector3 velocity;
  private float gravity = -19.62f;

 [SerializeField] private Transform groundCheck;
  private float groundDistance = 0.4f;
  [SerializeField] private LayerMask groundMask;

  private bool isGrounded;
  
  public Vector3 GetVelocity(){
    isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0 )
        {
            velocity.y = -2f;
        }
    velocity.y += gravity * Time.deltaTime;

    return velocity;
}
}



