//Made by Joel Draper for MansionGaming.
using UnityEngine;
using System.Collections;

public class HealthAddon : MonoBehaviour {

    public ScoreBasics score;
    public HealthBasics health;
    public GameObject other;

    public int healthPoints;
    public int scorePoints; //Optional 

    public void resetHealth()
    {
        health.health += 100;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Trigger is player - Health Pickup");
            score.score += scorePoints; //The player gains score 
            health.health += healthPoints; //When the player enters the object, they get the amount of health the user specifies
            Destroy(gameObject); //When the player picks up the object, destroy the dough
        }
        else
        {
            Debug.Log("Trigger is not player - Health Pickup");
        }
    }

    void OnDestroy()
    {
        other.GetComponent<AudioSource>().Play(); //When object is destroyed, play sound
    }
}
