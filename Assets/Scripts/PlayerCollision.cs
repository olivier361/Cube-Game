//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //YOU DON'T NEED THESE DEFAULT Start() & Update() functions for Collisions.
    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */

    public PlayerMovement movement; //connect to the script this references in the unity inspector.
    //public GameManager gameManager;

    void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log("We hit something!");
        //Debug.Log(collisionInfo.collider.name); //This displays the name of the object we hit.

        //This will run the code if we specifically hit an Obstacle object.
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            //Debug.Log("Play Sound: Crash!");
            FindObjectOfType<AudioManager>().Play("PlayerCrash"); //Calls the AudioManager to play the instructed sound.
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
