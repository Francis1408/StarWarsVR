using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HitDetection : MonoBehaviour
{
    // Start is called before the first frame update
    public Shaking shaking;
    public int health;

    public Image[] lifes;

    public GameObject Explosion;

    public AudioSource gameSoundTrack;

    public AudioSource hullHit;

    public Image warning;
    public AudioSource warningSound;

    public ParticleSystem smoke;

    public ParticleSystem sparks;

    private SceneManagerScript sceneManager;


    void Start()
    {
        warning.enabled = false;
        smoke.Stop();
        sparks.Stop();
        sceneManager = GetComponent<SceneManagerScript>();

    }
    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "laser")
        {
            health -= 1;
            lifes[health].enabled = false;
            hullHit.Play(0);
            Destroy(collision.gameObject);
            StartCoroutine(shaking.Shake());
        }

        if (health <= 5)
        {
            sparks.Play();
        }

        if (health <= 3)
        {
            warning.enabled = true;
            warningSound.Play();
            smoke.Play();

        }

        if (health <= 0)
        {
            gameSoundTrack.Stop();
            Instantiate(Explosion, transform.position, Quaternion.identity);
            //Destroy(gameObject);
            sceneManager.NextScene("Enviroment");
        }
    }

    void Update()
    {

    }

}
