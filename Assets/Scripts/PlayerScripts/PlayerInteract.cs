using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField]private new Camera camera;
    [SerializeField] private float distance = 3f;
    [SerializeField] private LayerMask layerMask;
    private PlayerUI playerUI;
   [SerializeField] private Input input;

    // Start is called before the first frame update
    void Start()
    {
        playerUI = GetComponent<PlayerUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        playerUI.UpdateText(string.Empty);
        Ray ray = new Ray(camera.transform.position, camera.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);

        RaycastHit hitInfo; //variable to store our collision information
        if (Physics.Raycast(ray, out hitInfo ,distance, layerMask)) //if hit something:
        {
            if (hitInfo.collider.GetComponent<Interactable>() != null)//if the thing we hit is interactable
            {
                // Debug.Log(hitInfo.collider.GetComponent<Interactable>().prompt);
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();//if it is interactable then we store it in variable
                playerUI.UpdateText(interactable.prompt);
                if (input.InteractTriggered())
                {
                    interactable.BaseInteract();
                }
            }
        }
        
    }
}
