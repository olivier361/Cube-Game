//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame() //Start() is allready a base unity function so avoid that.
    {
        FindObjectOfType<AudioManager>().Play("MenuSelect"); //Calls the AudioManager to play the instructed sound.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
