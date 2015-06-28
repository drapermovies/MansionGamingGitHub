//Made by Joel Draper for MansionGaming. 
using UnityEngine;
using System.Collections;

public class killPlayer : MonoBehaviour {

    public HealthBasics health;

	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "Player") {
			health.health = 0; //When player enters, they die. 
		}
	}
}
