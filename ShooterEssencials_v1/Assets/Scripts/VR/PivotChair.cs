using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotChair : MonoBehaviour
{
    public HandleVR handleVR;

    public Vector2 horizontalLimits;
    public Vector2 verticalLimits;
    public float horizontalSpeed;
    public float verticalSpeed;

    public Vector3 offset;

    protected Vector3 currentRotation;

    void Update()
    {
        Vector2 control = handleVR.GetDirection();
        Vector3 rotation = Vector3.up * control.x * horizontalSpeed + Vector3.right * control.y * verticalSpeed;
        currentRotation = currentRotation + rotation * Time.deltaTime;
        currentRotation.y = Mathf.Clamp(currentRotation.y, horizontalLimits.x, horizontalLimits.y);
        currentRotation.x = Mathf.Clamp(currentRotation.x, verticalLimits.x, verticalLimits.y);
        transform.rotation = Quaternion.Euler(currentRotation) * Quaternion.Euler(offset);
    }
}
