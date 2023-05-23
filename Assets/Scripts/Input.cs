using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input : MonoBehaviour
{
   private PlayerInputActions playerInputActions;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        // Debug.Log(inputVector);
        return inputVector;
    }

    public Vector2 GetLookInput(){
        Vector2 inputVector = playerInputActions.Player.Look.ReadValue<Vector2>();

        return inputVector * Time.deltaTime;
    }

    public bool InteractTriggered(){
        return playerInputActions.Player.Interact.triggered;
    }
}
