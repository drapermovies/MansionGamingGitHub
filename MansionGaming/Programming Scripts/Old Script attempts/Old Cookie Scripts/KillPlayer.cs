//Created by Joel Draper for MansionGaming. 
using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

    public LevelManager levelManager;

    public HealthSystem health;

	void Start () {
        levelManager = FindObjectOfType<LevelManager>();
	}

    void OnTriggerEnter2D(Collider2D other)
    {
   	    if (other.name == "Player") {
            health.TakeDamage(5);
		}
    }
}