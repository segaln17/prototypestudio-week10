using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatusChanger : MonoBehaviour
{
    public TextMeshProUGUI statusText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Amber"))
        {
            statusText.text = "is that honey??? the perfect snack...";
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Food"))
        {
            statusText.text = "delicious but still hungry...";
        }
        if (other.gameObject.CompareTag("Socks"))
        {
            statusText.text = "delightfully smelly but still, hungry...";
        }
        if (other.gameObject.CompareTag("Trash"))
        {
            statusText.text = "still not food...";
        }
    }
}
