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
    public Rigidbody rb3;
    public Rigidbody rb4;
    public Transform SpawnPoint;
    public Transform SpawnPoint2;


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
            Vector3 xsidewards = new Vector3(-moveforce, 0, 0);
            rb.AddForce(xsidewards);
        }

        if(Input.GetKey(KeyCode.A))
        {
            Vector3 x2sidewards = new Vector3(moveforce, 0, 0);
            rb.AddForce(x2sidewards);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 Position = SpawnPoint2.position;
            Rigidbody clone;
            clone = Instantiate(rb2, Position, transform.rotation);
            clone.velocity = transform.TransformDirection(ForceSphere, 0f,0f);

            Vector3 Shootingforce = new Vector3(ForceSphere, 0, 0);
            rb2.AddForce(Shootingforce);
        }

        //Second Player
        if (Input.GetKeyDown(KeyCode.M))
        {
            Vector3 force = new Vector3(0, jumpforce, 0);
            rb3.AddForce(force);
        }
        if (Input.GetKey(KeyCode.L))
        {
            Vector3 forcesidewards = new Vector3(-moveforce, 0, 0);
            rb3.AddForce(forcesidewards);
        }
        if (Input.GetKey(KeyCode.J))
        {
            Vector3 forcesidewards = new Vector3(moveforce, 0, 0);
            rb3.AddForce(forcesidewards);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Vector3 Player2Position = SpawnPoint.position;
            Rigidbody clone;
            clone = Instantiate(rb4, Player2Position, transform.rotation);
            clone.velocity = transform.TransformDirection(ForceSphere, 0f, 0f);

            Vector3 Shootingforce = new Vector3(ForceSphere, 0, 0);
            rb4.AddForce(Shootingforce);
        }
    }
}
