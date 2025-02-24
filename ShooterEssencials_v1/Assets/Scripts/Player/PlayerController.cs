using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool disabled = false;

    void SetActive(bool state) {
        disabled = state;
    }
   
}
