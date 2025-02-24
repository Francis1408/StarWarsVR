using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject EnemyPrefab1;


    public GameObject EnemyPrefab2;
    

    public GameObject EnemyPrefab3;
    
    public AudioSource spawnSound;
    public Vector3 position;
    // Start is called before the first frame update

    public float period;

    public int MobCap;

    private float counter;

    private int Name = 0;

    private EnemyMovementSound movementSound;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter >= period)
        {
            counter = 0;
            int numberOfClassObjects = GameObject.FindGameObjectsWithTag("Enemies").Length;
            if (numberOfClassObjects < MobCap)
            {   
                spawnSound.Play(0);
                int a = Random.Range(0, 12);
                if (a < 4)
                {
                    
                    GameObject Enemy = GameObject.Instantiate(EnemyPrefab1, position, Quaternion.identity);
                    Enemy.name = Name.ToString();
                }
                else if (a > 4 && a < 8)
                {
                  

                    GameObject Enemy = GameObject.Instantiate(EnemyPrefab2, position, Quaternion.identity);
                    Enemy.name = Name.ToString();
                }
                else
                {

                    GameObject Enemy = GameObject.Instantiate(EnemyPrefab3, position, Quaternion.identity);
                    Enemy.name = Name.ToString();
                }
                Name++;
            }
        }

    }

}
