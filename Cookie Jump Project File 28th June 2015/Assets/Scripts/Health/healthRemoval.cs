//Made by Joel Draper for MansionGaming
using UnityEngine;
using System.Collections;

public class healthRemoval : MonoBehaviour {

    public HealthBasics health;
    public ScoreBasics score;
    public GameObject audio;

    public int healthLoss;
    public int scoreLoss;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            score.score -= scoreLoss; //The player loses points when they touch the area
            health.health -= healthLoss; //When the player touches this object, they lose amount of health the user specifies 
            audio.GetComponent<AudioSource>().Play(); //When player loses health, play sound
        }
    }
}
