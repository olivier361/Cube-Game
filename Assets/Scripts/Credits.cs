//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    string MenuName = "Menu";

    public void Quit ()
    {
        FindObjectOfType<AudioManager>().Play("MenuSelect"); //Calls the AudioManager to play the instructed sound.
        Application.Quit(); //this closes the application if it is actually built as an application that is.
        Debug.Log("You quit the game.");
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f; //This makes sure your game doesn't stay paused when going to the menu.
        FindObjectOfType<AudioManager>().Play("MenuSelect"); //Calls the AudioManager to play the instructed sound.
        Debug.Log("Loading Menu...");
        SceneManager.LoadScene(MenuName);
    }
}
