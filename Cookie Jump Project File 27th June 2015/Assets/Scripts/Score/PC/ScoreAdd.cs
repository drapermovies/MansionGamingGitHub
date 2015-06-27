//Made by Joel Draper for MansionGaming 
using UnityEngine;
using System.Collections;

public class ScoreAdd : MonoBehaviour {

    public ScoreBasics scoreM;

    public int points;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            scoreM.score += points; //When the player touches this object, they gain the amount of points the user specifies
        }
    }
}
