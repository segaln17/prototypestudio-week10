using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    public Rigidbody rb;

    private TrailRenderer trail;
    
    public float force = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        trail = GetComponent<TrailRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
            -Camera.main.transform.position.z));

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }
}
