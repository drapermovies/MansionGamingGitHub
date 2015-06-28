//Made by Joel Draper for MansionGaming 
using UnityEngine;
using System.Collections;

public class respawnCheckpoint : MonoBehaviour {

    public RespawnBasics respawn; 

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            respawn.currentCheckpoint = gameObject;
        }
    }
}
