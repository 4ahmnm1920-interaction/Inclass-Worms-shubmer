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
    public KeyCode Shootkeyplayer1;
    public KeyCode jumpplayer1;
    public KeyCode moveleftplayer1;
    public KeyCode moverightplyer1;

    public KeyCode Shootkeyplayer2;
    public KeyCode jumpplayer2;
    public KeyCode moveleftplayer2;
    public KeyCode moverightplyer2;



    void Update()
    {
        if (Input.GetKeyDown(jumpplayer1))
        {
            Vector3 force = new Vector3(0,jumpforce,0);
            rb.AddForce(force);
            //Debug.Log("Space is pressed");
        }
        if (Input.GetKey(moverightplyer1))
        {
            Vector3 xsidewards = new Vector3(-moveforce, 0, 0);
            rb.AddForce(xsidewards);
        }

        if(Input.GetKey(moveleftplayer1))
        {
            Vector3 x2sidewards = new Vector3(moveforce, 0, 0);
            rb.AddForce(x2sidewards);
        }
        if (Input.GetKeyDown(Shootkeyplayer1))
        {
            Vector3 Position = SpawnPoint2.position;
            
            Rigidbody clone = Instantiate(rb2, Position, transform.rotation);
            clone.velocity = transform.TransformDirection(-ForceSphere, 0f, 0f);

            Vector3 Shootingforce = new Vector3(ForceSphere, 0, 0);
            rb2.AddForce(Shootingforce);

            Destroy(clone, 1);
        }


        //Second Player
        if (Input.GetKeyDown(jumpplayer2))
        {
            Vector3 force = new Vector3(0, jumpforce, 0);
            rb3.AddForce(force);
        }
        if (Input.GetKey(moverightplyer2))
        {
            Vector3 forcesidewards = new Vector3(-moveforce, 0, 0);
            rb3.AddForce(forcesidewards);
        }
        if (Input.GetKey(moveleftplayer2))
        {
            Vector3 forcesidewards = new Vector3(moveforce, 0, 0);
            rb3.AddForce(forcesidewards);
        }
        if (Input.GetKeyDown(Shootkeyplayer2))
        {
            Vector3 Player2Position = SpawnPoint.position;
            Rigidbody clone;
            clone = Instantiate(rb4, Player2Position, transform.rotation);
            clone.velocity = transform.TransformDirection(ForceSphere, 0f, 0f);

            Vector3 Shootingforce = new Vector3(ForceSphere, 0, 0);
            rb4.AddForce(Shootingforce);

            Destroy(clone, 1);
        }

    }
 
}
