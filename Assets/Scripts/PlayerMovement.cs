//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This is a reference to the Rigidbody component called "rb".
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 100f;
    bool played = false; //checks if fall sounds played already. avoids repeats since it's in updates.

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello World!");
        rb.useGravity = true;
        //rb.AddForce(float x, float y, float z);
        //rb.AddForce(0,200,500);
    }

    // Update is called once per frame
    void FixedUpdate() //Using FixedUpdate rather than Update is recommended when using physics.
    {
        //Time.deltTime//
        /*
        //is a multiplier of how many times per seconds (frames) this code is repeated.
        //This is used to make sure your movement force stays constant even if the framerate
        //of the game or computer performance varies.
        */
        //This adds a forwardForce to the player.
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //add a force on the z-axis.
        //Debug.Log(Time.deltaTime);


        if ( Input.GetKey("d") )
        {
            rb.AddForce( sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce( -sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            if (played == false) //just checks if the sound played already to avid repeats.
            {
                FindObjectOfType<AudioManager>().Play("PlayerFall"); //Calls the AudioManager to play the instructed sound.
                played = true;
            }
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
