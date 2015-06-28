//Made by Joel Draper for MansionGaming.
using UnityEngine;
using System.Collections;

public class pauseState : MonoBehaviour
{
    public bool paused;

    public PlayerFunctions playerF;

    public GameObject guiCanvas;
    public GameObject pauseMenuCanvas;

    public void update()
    {
        if (paused)
        {
            playerF.isActive = false;
            Debug.Log("game is paused");
        }
        else
        {
            playerF.isActive = true;
        }
    }

    public void pauseStates()
    {
        Time.timeScale = 0f; //On button click, stop time 
        paused = true; //This is intended for audio sources, so I can pause audio sources if the game is paused
        if (paused)
        {
            pauseMenuCanvas.SetActive(true);
            guiCanvas.SetActive(false);
            paused = true;
        }
    }

}