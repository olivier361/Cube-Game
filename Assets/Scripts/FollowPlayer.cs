//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    //a vector3 is a datatype that stores three float values; an x,y,z.
    public Vector3 offset;

    /*
    // Start is called before the first frame update
    void Start()
    {
        
    }
    */


    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position);
        //transform with NO CAPS refers to the transform of the camera for which this script belongs to.
        transform.position = player.position + offset;
    }
}
