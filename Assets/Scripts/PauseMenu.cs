using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    string MenuName = "Menu";

    /*NOTE:
     * If you want to check the paused state in another game script, you can check the GameIsPaused variable.
     * 
     * EX:
     * if (PauseMenu.GameIsPaused == true)
     * {
     *    [sound name].source.pitch *= 0.5f;
     * }
     * 
     * This example code was used to change the sound pitch of game sounds in an AudioManager since the time freeze doesn't stop sounds.
    */
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }


    public void Resume()
    {
        FindObjectOfType<AudioManager>().Play("MenuSelect"); //Calls the AudioManager to play the instructed sound.
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }


    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f; //This unity function can be used to change time speed. so 0 is stopped and you could use this to do slow motion effects.
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f; //This makes sure your game doesn't stay paused when going to the menu.
        FindObjectOfType<AudioManager>().Play("MenuSelect"); //Calls the AudioManager to play the instructed sound.
        Debug.Log("Loading Menu...");
        SceneManager.LoadScene(MenuName);
    }

    public void QuitGame()
    {
        Debug.Log("You quit the game.");
        FindObjectOfType<AudioManager>().Play("MenuSelect"); //Calls the AudioManager to play the instructed sound.
        Application.Quit();
    }


} //End of PauseMenu.
