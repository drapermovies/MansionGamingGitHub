//Made by Joel Draper for MansionGaming 
using UnityEngine;
using System.Collections;

public class respawnCheckpointAndroid : MonoBehaviour {

    public RespawnBasicsAndroid respawn; 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            respawn.currentCheckpoint = gameObject;
        }
    }
}
