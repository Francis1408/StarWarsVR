using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepsEffect : MonoBehaviour
{
   public GameObject footstep;
    void Start()
    {
        footstep.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            StartFootSteps();
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            StopFootSteps();
        }
    }

    void StartFootSteps()
    {
       footstep.SetActive(true);
    }

    void StopFootSteps()
    {
         footstep.SetActive(false);
    }
}
