//Made by Joel Draper for MansionGaming. 
using UnityEngine;
using System.Collections;

public class soggyStateAndroid : MonoBehaviour {

    public HealthBasicsAndroid health;
    //public soggyPickup soggyPickup; 

    public bool isSoggy = false; 

    private float timer = 0; //Timer for removing health (temporary)
    private float timer1 = 0; //Timer for removing sogginess (temporary) 

    public GameObject soggyAudio; //Sound to play when taking "soggy" damage

    void Update()
    {
        if (isSoggy)
        {
          timer += Time.deltaTime; //Starts timer
          timer1 += Time.deltaTime; //Starts timer 1
            if (timer > 1)
            {
                Debug.Log("Player is soggy");
                health.health -= 10; //Player loses 10 points of health a second 
                timer = 0; //Reset timer when it reaches 1
                soggyAudio.GetComponent<AudioSource>().Play(); //When player is soggy, play sound
            }

            if (timer1 > 10)
            {
                isSoggy = false; //After 10 seconds, player is no longer "soggy" 
                Debug.Log("player is no longer soggy");
            }
        }
    }
}
