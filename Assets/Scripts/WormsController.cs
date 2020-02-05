using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormsController : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpforce;
    public float moveforce;
    public Rigidbody rb2;
    public float ForceSphere;


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
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 PositionSphere = new Vector3(0.5f, 0.5f, 0);
            Rigidbody clone;
            clone = Instantiate(rb2, transform.position + PositionSphere, transform.rotation);
            clone.velocity = transform.TransformDirection(ForceSphere, 0f,0f);

            Vector3 Shootingforce = new Vector3(ForceSphere, 0, 0);
            rb2.AddForce(Shootingforce);

            
        }
    }
}
