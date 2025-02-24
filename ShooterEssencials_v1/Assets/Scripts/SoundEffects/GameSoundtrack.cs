using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSoundtrack : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource gameaudio;
    void Start()
    {
        gameaudio.loop = true;
        gameaudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
