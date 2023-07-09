//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

  void OnTriggerEnter()
    {
        FindObjectOfType<AudioManager>().Play("LevelEnd"); //Calls the AudioManager to play the instructed sound.
        gameManager.CompleteLevel();
    }


}
