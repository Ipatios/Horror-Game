using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSpeed = 100f;
   [SerializeField] private Transform playerBody;

    [SerializeField] private Input lookInput;



    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        // hides the cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = lookInput.GetLookInput().x * mouseSpeed * Time.deltaTime;
        float mouseY = lookInput.GetLookInput().y * mouseSpeed * Time.deltaTime;
        // we put it on - because if put on + the up and down look is reverted
        // meaning when mouse goes up player looks down
        xRotation -= mouseY;
        // so it doesnt end up looking behind the player
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        // look up and down
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        // look left and right
        playerBody.Rotate(Vector3.up * mouseX);
    }
    
}
