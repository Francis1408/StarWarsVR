using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBobbing : MonoBehaviour
{
    public GameObject Camera;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            StartBobbing();
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            StopBobbing();
        }
    }

    void StartBobbing()
    {
        Camera.GetComponent<Animator>().Play("HeadBobbing");
    }

    void StopBobbing()
    {
        Camera.GetComponent<Animator>().Play("New State");
    }
}
