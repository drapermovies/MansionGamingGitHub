//Made by Joel Draper for MansionGaming. 
using UnityEngine;
using System.Collections;

public class buttonsAndroid : MonoBehaviour
    
{
    public bool paused = false;

    public PlayerFunctionsAndroid player;
    public RespawnBasicsAndroid respawn;

    public GameObject guiCanvas;
    public GameObject pauseMenuCanvas;
    public GameObject gameOverCanvas;
    public GameObject achievCanvas;

    public void pauseState ()
    {
        Time.timeScale = 0f; //On button click, stop time 
        paused = true; //This is intended for audio sources, so I can pause audio sources if the game is paused
        player.playerBool = 0;
        Debug.Log("paused button clicked");
        if (paused)
        {
            pauseMenuCanvas.SetActive(true);
            guiCanvas.SetActive(false);
        }
    }

    public void resume ()
    {
        Debug.Log("resume button is clicked");
        paused = false;
        Time.timeScale = 1f;
        pauseMenuCanvas.SetActive(false);
        guiCanvas.SetActive(true);
    }

    public void creditsButton ()
    {
        Debug.Log("credits button is clicked");
        Application.LoadLevel("Tech Demo Credits");
    }

    public void restartButton ()
    {
        player.playerBool = 0;
        Debug.Log("restart");
        Application.LoadLevel(1);
    }

    public void backFromCredits ()
    {
        Debug.Log("back from credits");
        Application.LoadLevel("Android Demo Build 1");
    }

    public void storeButton ()
    {
        Debug.Log("load store");
        Application.LoadLevel("Tech Demo Store");
    }

    public void achievButton ()
    {
        respawn.playerDead = false;
        Debug.Log("achieve button");
        guiCanvas.SetActive(false);
        pauseMenuCanvas.SetActive(false);
        gameOverCanvas.SetActive(false);
        achievCanvas.SetActive(true);
        Time.timeScale = 0f; //On button click, stop time 
    }
}
