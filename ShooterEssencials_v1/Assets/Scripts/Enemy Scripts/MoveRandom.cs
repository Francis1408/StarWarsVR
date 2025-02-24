using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRandom : MonoBehaviour

{
    public float sphereRadius = 4f; // Radius of the imaginary sphere
    public float moveInterval = 0.4f; // Time interval between movements
    private float timer = 0f;
    private Vector3 targetPosition;

    void Start()
    {
        MakeRandomLocationOnSphere();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= moveInterval)
        {
            MakeRandomLocationOnSphere();
            timer = 0f;
        }
    }

    void MakeRandomLocationOnSphere()
    {

        Vector3 randomDirection = Random.onUnitSphere;
        while(randomDirection.y<0 || randomDirection.z>-0.8){
            randomDirection = Random.onUnitSphere;
        }
        targetPosition = randomDirection * sphereRadius;
        transform.position = targetPosition;
    }
}

