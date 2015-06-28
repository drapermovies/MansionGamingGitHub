//Created by Joel Draper for MansionGaming
using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

   //public static bool pause;

    public bool muteAudio;

    //public AudioSource bgMusic;

    void Start()
    {
        Debug.Log("audio manager is active");
    }

    void Update()
    {
        Debug.Log("audio update");
        if (!muteAudio)
        {
            Debug.Log("mute is false");
            AudioListener.volume = 1;
        }
        if (muteAudio)
        {
            Debug.Log("mute is true");
            //AudioListener.pause = true;
            AudioListener.volume = 0;
        }
    }
}
