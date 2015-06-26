//Made by Joel Draper for Mansion Gaming. 
using UnityEngine;
using System.Collections;

public class soggyZone : MonoBehaviour {

    public soggyState soggy;

    public GameObject soggyAudio;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            soggy.isSoggy = true; //When player picks up the object, they become soggy 
            soggyAudio.GetComponent<AudioSource>().Play(); //When player is soggy, play sound
        }
    }
}