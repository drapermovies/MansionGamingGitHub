//Made by Joel Draper for MansionGaming. 
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttons : MonoBehaviour
    
{
    public bool paused = false;
	public bool muteAudio = false;

    public PlayerFunctions player;
    public RespawnBasics respawn;
	public AudioManager audioM;
	//public spriteManager spriteM;

    public GameObject guiCanvas;
    public GameObject pauseMenuCanvas;
    public GameObject gameOverCanvas;
    public GameObject achievCanvas;
    public GameObject startGUI;

	public Toggle toggle;

	void Start()
	{
		//GetComponent<UnityEngine.UI.Toggle> ();
		var toggle =  GetComponent<UnityEngine.UI.Toggle>();
	}

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
        Application.LoadLevel(1);
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
        startGUI.SetActive(false);
        gameOverCanvas.SetActive(false);
        achievCanvas.SetActive(true);
        Time.timeScale = 0f; //On button click, stop time 
    }

	public void muteButton () 
	{
		Debug.Log ("mute button is active");
		if (muteAudio) {
			//spriteM.muteAudio = true; 
			audioM.muteAudio = true;
			Debug.Log("button manager, mute audio.");
		}
		if (!muteAudio){
			//spriteM.muteAudio = false;
			audioM.muteAudio = false;
			Debug.Log("Audio not muted, button manager");
			muteAudio = true;
		}
	}

	void Update()
	{
		if (muteAudio)
			muteAudio = false;
		if (!muteAudio)
			Debug.Log("Audio not muted, button manager");
	}
}
