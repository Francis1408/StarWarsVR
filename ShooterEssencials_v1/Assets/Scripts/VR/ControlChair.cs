using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlChair : MonoBehaviour
{
    public Transform aimingPoint;
    public Transform cannon;
    public float distanceToAim;


    // Update is called once per frame
    void Update()
    {
        cannon.LookAt(aimingPoint.position + aimingPoint.forward * distanceToAim);
    }
}
