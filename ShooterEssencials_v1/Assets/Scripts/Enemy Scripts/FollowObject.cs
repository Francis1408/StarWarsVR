using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public float followSpeed = 6f; // Speed at which this object follows the target
    
    public GameObject Target_Object;
    private Transform target; // The object to follow
    void Start()
    {
        GameObject Target = GameObject.Instantiate(Target_Object);
        target = Target.transform;
        Target.name = "Look"+transform.name;     
    }
    void Update()
    {
        if (target != null)
        {
            // Calculate the direction towards the target
            Vector3 direction = (target.position - transform.position).normalized;

            // Calculate the distance to the target
            float distance = Vector3.Distance(transform.position, target.position);

            // Move towards the target
            transform.position += direction * followSpeed * Time.deltaTime;

            // Ensure the object doesn't overshoot the target
            if (distance < followSpeed * Time.deltaTime)
            {
                transform.position = target.position;
            }
        }
    }
}