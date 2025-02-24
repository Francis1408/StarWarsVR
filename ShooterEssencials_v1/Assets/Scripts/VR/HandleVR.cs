using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleVR : MonoBehaviour
{
    public Transform[] hands;
    public Transform pivot;
    

    public Vector2 GetDirection()
    {
        Vector3 average = hands[1].forward + hands[0].forward;
        average *= .5f;
        return new Vector2(Vector3.Dot(average, pivot.right), Vector3.Dot(average, pivot.up));
        // //vertical
        // //Calculate line between two hands
        // // Vector3 diference = hands[1].position - hands[0].position;
        // //Remove vertical component
        // Vector3 projected = Vector3.ProjectOnPlane(diference, pivot.up);
        // //How much right or left component do we have
        // float dot = Vector3.Dot(projected.normalized, pivot.forward);

        // //Vertical
        // Vector3 projectedSide = Vector3.ProjectOnPlane(diference, pivot.right);
        // float dotSide = Vector3.Dot(projectedSide.normalized, pivot.up);

        // return new Vector2(-dot, dotSide);

    }
}
