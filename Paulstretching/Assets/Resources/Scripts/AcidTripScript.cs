using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class AcidTripScript : MonoBehaviour
{
    //objects that move independently in this scene

    public float countdownTimer = 4f;
    public float initialTime = 4f;
    public float speed = 0.4f;
    private Vector3 start;
    public Vector3 end;

    private Vector3 temp;
    //private float time;
    public float amp = 4f;
    
    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
        temp = end;
        //Debug.Log(start);
        //end = new Vector3(-20.3f, 14.3f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, temp, speed * Time.deltaTime);
        if (transform.position == end)
        {
            temp = start;
        }
        else if (transform.position == start)
        {
            temp = end;
        }
        /*
        if (transform.position != end)
        {
            transform.position = Vector3.MoveTowards(transform.position, end, Time.deltaTime * speed);
            countdownTimer -= Time.deltaTime;
        }
        else //if(countdownTimer >= -initialTime && countdownTimer < 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, start, Time.deltaTime * speed);
            countdownTimer += Time.deltaTime;
            Debug.Log("back");
        }
        */

    }
    
}
