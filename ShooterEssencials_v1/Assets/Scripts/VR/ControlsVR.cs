using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsVR : MonoBehaviour
{
    public enum ControlOption
    {
        Position, Orientation
    }
    public Transform[] hands;

    public Transform pivot;

    public ControlOption controlOption;


    // Update is called once per frame
    void Update()
    {
        //Option 1
        if(controlOption == ControlOption.Position)
        {
            Vector3 averagePosition = hands[1].position + hands[0].position;
            Vector3 direction = pivot.position - averagePosition*.5f;

            transform.rotation = Quaternion.LookRotation(direction);
        }
        else
        {
            Vector3 averageDirection = hands[1].forward + hands[0].forward;
            transform.rotation = Quaternion.LookRotation(averageDirection*.5f);
        }


    }

    /// <summary>
    /// Callback to draw gizmos that are pickable and always drawn.
    /// </summary>
    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Vector3 difference = hands[1].position - hands[0].position;
        Gizmos.DrawLine(hands[1].position, hands[0].position);
    }
}
