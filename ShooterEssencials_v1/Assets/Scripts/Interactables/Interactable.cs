using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{  
    //message displayed to a player when looking at an interactable
    public string promptMessage;
    public string buttonMessage;
    public void BasicInteract() {
        Interact();
    }

    protected virtual void Interact() {
        // Template to be overriden by our sublcasses
    }
    
}
