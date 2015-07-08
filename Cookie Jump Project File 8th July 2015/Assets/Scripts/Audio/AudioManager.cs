//Created by Joel Draper for MansionGaming
using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    public bool muteAudio;
	public bool pause;

	//public spriteManager spriteMan;

	public GameObject bgMusic;

    void Start()
    {
        Debug.Log("audio manager is active");

//		spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
//		if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
//			spriteRenderer.sprite = muteAudioSprite; // set the sprite to sprite1
    }

    void Update()
    {
		Debug.Log ("audio update");
		if (!muteAudio) {
			Debug.Log ("mute is false");
			AudioListener.volume = 1;
//			AudioSource.PlayClipAtPoint;
//			spriteRenderer.sprite = muteAudioSprite;
			//spriteMan.muteAudio = false;
		}
		if (muteAudio) {
			Debug.Log ("mute is true");
			//AudioListener.pause = true;
			AudioListener.volume = 0;
//			AudioSource.pause;
//			spriteRenderer.sprite = unmuteAudioSprite;
			//spriteMan.muteAudio = true;
		}
		if (pause) {
			bgMusic.GetComponent<AudioSource>().Pause();
		}
		/*else if (!pause) 
		{
			bgMusic.GetComponent<AudioSource>().Play();
		}*/
	}
}
