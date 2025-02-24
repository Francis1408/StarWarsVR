using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

//using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using HTC.UnityPlugin.Vive;

public class Raycast1 : MonoBehaviour
{
    public float maxDistance = 10f; // Maximum distance of the Raycast
    public LayerMask layerMask; // Layer mask to determine which layers the ray should collide with

    public LineRenderer lineRenderer;
    
    public int counter;

    public int Cooldown;

    public int Cooldown2;

    public int counter2;

    public bool State = false;

    public TMP_Text PointBoard;

    public int points;
    
    public GameObject Explosion;

    public AudioSource Pew;

    void Start(){
        lineRenderer = FindObjectOfType<LineRenderer>();
    }

    void Update()
    {
        // Calculate the direction in which to cast the ray (forward from the object)
        Vector3 direction = transform.forward;
        bool shoot = Input.GetKeyDown(KeyCode.Space);
        shoot = shoot || ViveInput.GetPressDown(HandRole.RightHand, ControllerButton.Trigger) 
                      || ViveInput.GetPressDown(HandRole.LeftHand, ControllerButton.Trigger);
        if(shoot){
            if(State==false){
                    counter=0; counter2=0;
                    State=true;
                    Pew.Play(0);
            }
        }
        if(State==true){
            if(counter<Cooldown){
                counter++;
                // Perform the RayCast
                RaycastHit hit;
                lineRenderer.SetPosition(0,transform.position);
                if (Physics.Raycast(transform.position,direction, out hit, maxDistance, layerMask))
                {
                    // If the sphere hits something, log the information
                    Debug.Log("Raycast hit: " + hit.collider.gameObject.name);
                    lineRenderer.SetPosition(1,hit.point);

                    if(hit.collider.gameObject.name != "Plane"){
                        if(hit.collider.gameObject.name == "laser"){
                            Destroy(hit.collider.gameObject);
                            points +=1;
                        }
                        else{
                            GameObject.Instantiate(Explosion,hit.point,Quaternion.identity);
                            Destroy(GameObject.Find("Look"+hit.collider.gameObject.name));
                            Destroy(GameObject.Find(hit.collider.gameObject.name));
                            points +=2;
                        }
                        if(PointBoard != null)
                            PointBoard.text = points.ToString();
                    }
                }
                else
                {
                    // If the sphere doesn't hit anything, log that it didn't hit anything
                    // Debug.Log("Raycast didn't hit anything");
                    //target.transform.position = transform.position + transform.forward*-1*maxDistance;
                    lineRenderer.SetPosition(1,transform.position + transform.forward*maxDistance);
                }
            }
            else{
                lineRenderer.SetPosition(0,transform.position);
                lineRenderer.SetPosition(1,transform.position);
                if(counter2<Cooldown2) counter2++;
                else State = false;
            }
        }
    }
}