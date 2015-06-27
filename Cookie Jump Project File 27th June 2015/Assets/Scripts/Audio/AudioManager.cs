//Created by Joel Draper for MansionGaming
using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    public static bool pause;

    public bool muteAudio = true;

   // public AudioSource bgMusic;

    void Start()
    {
      //  bgMusic = GetComponent<AudioSource>();
    }

    void update()
    {
        if (!muteAudio)
        {
            Debug.Log("mute is false");
            //bgMusic.GetComponent<AudioSource>().Play(); //When game starts, the music starts
        }
        if (muteAudio)
        {
            Debug.Log("mute is true");
            AudioListener.pause = true;
            AudioListener.volume = 0;
        }
    }
}
