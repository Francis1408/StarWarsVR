using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementSound : MonoBehaviour
{
    public AudioSource movementSound;
    public void PlaySound() {
        movementSound.Play();
    }
}