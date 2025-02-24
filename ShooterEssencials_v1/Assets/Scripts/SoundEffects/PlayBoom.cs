using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBoom : MonoBehaviour

{
    // Start is called before the first frame update
    public AudioSource BoomSound;

    void Start()
    {
        BoomSound.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
