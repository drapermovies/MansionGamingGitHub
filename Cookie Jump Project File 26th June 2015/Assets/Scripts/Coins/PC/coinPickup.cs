//Made by Joel Draper for MansionGaming. 
using UnityEngine;
using System.Collections;

public class coinPickup : MonoBehaviour {

    public GameObject other;
    public ScoreBasics scoreM;
    public coinManager coins;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Trigger is player - Coin Pickup");
            scoreM.score += 25; //When the player touches this object, they gain 25 points 
            coins.gold += 1;
            Destroy(gameObject); //When the player picks up the object, destroy the coin
        }
        else
        {
            Debug.Log("Trigger is not player - Coin Pickup");
        }
    }

    void OnDestroy()
    {
        other.GetComponent<AudioSource>().Play(); //When object is destroyed, play sound
    }
}
