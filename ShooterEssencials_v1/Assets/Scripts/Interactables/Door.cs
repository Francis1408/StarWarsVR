using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    public Transform destination, player;
    public GameObject playerObj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {   
        // Teleport player to shppting cabin
        playerObj.SetActive(false);
        player.position = destination.position;
        playerObj.SetActive(true);
    }
}
