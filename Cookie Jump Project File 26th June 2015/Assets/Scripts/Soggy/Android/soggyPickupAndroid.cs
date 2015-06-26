//Made by Joel Draper for Mansion Gaming. 
using UnityEngine;
using System.Collections;

public class soggyPickupAndroid : MonoBehaviour {

    public soggyStateAndroid soggy;

    public GameObject soggyAudio;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Trigger is player - Milk Pickup");
            soggy.isSoggy = true; //When player picks up the object, they become soggy 
            Destroy(gameObject); //When the player picks up the object, destroy the pickup 
            soggyAudio.GetComponent<AudioSource>().Play(); //When player is soggy, play sound
        }
        else
        {
            Debug.Log("Trigger is not player - Milk Pickup");
        }
    }
}
