using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chair : Interactable
{

    private SceneManagerScript sceneManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Interact()
    {   
       sceneManager = GetComponent<SceneManagerScript>();
       sceneManager.NextScene("GamingScene");

    }
}
