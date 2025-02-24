using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockIn : MonoBehaviour
{
    public Transform Look; // The object to look at
    Vector3 myVector;
    public float xpos=0f;
    public float ypos=0f;
    public float zpos=0f;

    void Start(){
        //Transform target = LockTo.transform; // The object to follow
    }

    void Update()
    {
        if (Look != null)
        {
            myVector= new Vector3(xpos,ypos,zpos);
            // Make this object look at the target
            transform.LookAt(Look,myVector);
        }
    }
}
