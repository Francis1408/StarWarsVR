using System.Collections;
using System.Collections.Generic;
using HTC.UnityPlugin.Vive;
using UnityEngine;

public class PlayerMovementVR : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public Transform directionAxis;

    public HandRole handRole= HandRole.LeftHand;
    public ControllerAxis horizontalAxis = ControllerAxis.PadX;
    public ControllerAxis verticalAxis = ControllerAxis.PadY;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    Vector3 velocity;
    bool isGrounded;
    // Update is called once per frame

    void Update()
    {

            isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

            if (isGrounded && velocity.y < 0)
            {
                velocity.y = -2f;
            }

            float x = ViveInput.GetAxis(handRole, horizontalAxis);
            float z = ViveInput.GetAxis(handRole, verticalAxis);

            // Vector3 move = transform.right * x + transform.forward * z;
            Vector3 move = directionAxis.right * x + directionAxis.forward * z;
            move.y = 0;

            controller.Move(move * speed * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
        }
    }

