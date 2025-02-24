using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour


{
    public GameObject projectilePrefab;

    public Transform shootingPos;

    public float force;
    // Start is called before the first frame update

    private float counter;

    public float period;

    public AudioSource shotSound;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= period)
        {
            shoot();
            counter = 0;
        }

    }

    void shoot()
    {
        shotSound.Play(0);
        GameObject bullet = GameObject.Instantiate(projectilePrefab, shootingPos.position + shootingPos.forward * 0.5f, shootingPos.rotation);
        bullet.name = "laser";
        Rigidbody bulletRigid = bullet.GetComponent<Rigidbody>();
        bulletRigid.AddForce(shootingPos.forward * force);
    }
}
