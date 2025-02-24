using System.Collections;
using System.Collections.Generic;
using HTC.UnityPlugin.Vive;
using UnityEngine;

public class PlayerInteractVR : MonoBehaviour
{
    public Camera cam;

    public ControllerButton controllerButton = ControllerButton.Trigger;
    [SerializeField]
    private float distance = 3f;
    [SerializeField]
    private LayerMask mask;
    private PlayerUI playerUI;
    void Start()
    {
        playerUI = GetComponent<PlayerUI>();
    }

    // Update is called once per frame
    void Update()
    {
        playerUI.UpdatePromptText(string.Empty);
        playerUI.UpdateButtonText(string.Empty);
        playerUI.canvas.SetActive(false);
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, distance, mask)) {
            if(hitInfo.collider.GetComponent<Interactable>() != null) {
                Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
                playerUI.canvas.SetActive(true);
                playerUI.UpdatePromptText(interactable.promptMessage);
                playerUI.UpdateButtonText(interactable.buttonMessage);
                if(ViveInput.GetPressDown(HandRole.RightHand, controllerButton) || ViveInput.GetPressDown(HandRole.LeftHand, controllerButton)) {
                    interactable.BasicInteract();
                }

            }
        }
    }
}
