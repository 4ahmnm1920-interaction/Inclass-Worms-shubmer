using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormsController : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpforce;
    public float moveforce;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 force = new Vector3(0,jumpforce,0);
            rb.AddForce(force);
            Debug.Log("Space is pressed");
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 xsidewards = new Vector3(moveforce, 0, 0);
            rb.AddForce(xsidewards);
        }

        if(Input.GetKey(KeyCode.A))
        {
            Vector3 x2sidewards = new Vector3(-moveforce, 0, 0);
            rb.AddForce(x2sidewards);
        }

    }
}
