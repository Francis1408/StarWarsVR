using UnityEngine;

public class Sepuku2 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Myself;
    public int counter;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter--;
        if(counter<=0) Destroy(Myself);
    }
}
