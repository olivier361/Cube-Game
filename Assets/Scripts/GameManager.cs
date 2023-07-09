//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //allows us to change or reload scenes.

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevel ()
    {
        Debug.Log("YOU WON!");
        completeLevelUI.SetActive(true);
    }
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER!");

            Invoke("Restart", restartDelay); // the delays the call to funtion [string] by time [float].
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //you could use the specific string scene name "Level01" instead of SceneManager.GetActiveScene().name but this is more versatile.
    }
}
