using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour

{
    //public float rotationSpeed = 100f;
    public float distanceFromCamera = 8;
    
    Camera myCamera;

    void Start(){
        myCamera = Camera.main;
    }

    public Vector3 mousePos;
    void Update()
    {
        mousePos = Input.mousePosition;
        mousePos.z = distanceFromCamera;
        Vector3 mousePositionWorld = myCamera.ScreenToWorldPoint(mousePos);
        transform.LookAt(mousePositionWorld);
    }
}
