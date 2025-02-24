using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairMovement : MonoBehaviour
{

     public float sensX;
    public float sensY;
    //public Transform playerBody;

    float yRotation = 0f;


    private void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update() {

        // get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;
    
        yRotation -= mouseX;
        yRotation = Mathf.Clamp(yRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(0f, yRotation, 0f);
        
        //playerBody.Rotate(Vector3.up * mouseY);

        // rotate cam and orientation
        
        

    }
}
