//Made by Joel Draper for MansionGaming 
using UnityEngine;
using System.Collections;

public class ScoreAddAndroid : MonoBehaviour {

    public ScoreBasicsAndroid scoreM;

    public int points;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            scoreM.score += points; //When the player touches this object, they gain the amount of points the user specifies
        }
    }
}
