using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviromentSound : MonoBehaviour
{
    // Start is called before the first frame update
   private AudioSource music;
    void Start()
    {
        music = gameObject.GetComponent<AudioSource>();
        StartCoroutine(PlaySong());
        
    }

    // Update is called once per frame
    IEnumerator PlaySong() {

        yield return new WaitForSeconds(1);
        music.Play();
        music.loop = true;
        
        
  }
}
