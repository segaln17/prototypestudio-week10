using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoScript : MonoBehaviour
{
    public float timeBtwnSpawns;

    public float startTimeBtwnSpawns;

    public GameObject echo;

    private MouseMove playerMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timeBtwnSpawns <= 0)
        {
            //spawn echo game object
            GameObject instance = (GameObject)Instantiate(echo, transform.position, Quaternion.identity);
            Destroy(instance, 1f);
            timeBtwnSpawns = startTimeBtwnSpawns;
        }
        else
        {
            timeBtwnSpawns -= Time.deltaTime;
        }
    }
    
}
