using System.Collections;
using System.Collections.Generic;
//using System.Numerics;
using UnityEngine;

public class MoveLinear : MonoBehaviour
{
    // Start is called before the first frame update

    public float depth;
    public float InitialX;

    public float DeltaX;

    public float moveInterval;

    private float timer = 0f;

    private bool LeftOrRight=false;

    void Start()
    {
        transform.position = new Vector3(InitialX,2,depth);
    }

    // Update is called once per frame
    void Update()
    {
        timer+= Time.deltaTime;
        if(timer>=moveInterval){
            if(LeftOrRight == false) {
                moveleft();
                LeftOrRight = true;
                timer=0f;
            }
            else{
                moveright();
                LeftOrRight = false;
                timer=0f;
            }

        }
    }
    void moveleft(){
        transform.position = new Vector3(transform.position.x-DeltaX,transform.position.y+1,transform.position.z);
    }
    void moveright(){
        transform.position = new Vector3(transform.position.x+DeltaX,transform.position.y+1,transform.position.z);
    }

}
