//Made by Joel Draper for MansionGaming
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBasics : MonoBehaviour {

    //public Text text; 

    public ScoreBasics score;
    public RespawnBasics respawn;

    public GameObject deathAudio; //Sound to play when player dies

    private int healthMinus; //Health to take away 
    public int health = 100; //Health is equal to 100
    private float timer = 0; //Timer for removing health (temporary) 
    private float timer1 = 0; //Timer for adding 10
    private float timer2 = 0; //Timer for checking time 

    private bool isActive;

    void Start()
    {
            //text.text = health.ToString();
    }

    void Update() {
        Debug.Log("Health is " + health);

        if (!isActive)
        {
            if (Input.touchCount > 0)
            {
                if(Input.GetTouch(0).phase == TouchPhase.Began){
                isActive = true;
                }
            }
        }     
        
        if (isActive)
        {
            timer += Time.deltaTime; //Starts timer
        timer1 += Time.deltaTime; //Starts first timer
        timer2 += Time.deltaTime; //Starts second timer
            if (timer > 1) // has 1 second passed?
            {
                //text.text = health.ToString();
                health -= healthMinus;
                timer = 0;
            }

            if (timer2 < 10)
                healthMinus = 1;

            if (timer1 > 10)
            {
                healthMinus = healthMinus + 1;
                timer1 = 0;
            }

            if (healthMinus > health)
                healthMinus = health;
        }

        if (health == 0)
        {
            Debug.Log("Health is 0");
        }

        if (health <= 0)
        {
            score.timer1 = 0; //When player dies, the score multiplier resets
            score.timer2 = 0; //When the player dies, the score multiplier resets
            Debug.Log("Change health");
            healthMinus = 0; //When player dies, they shouldn't lose points from before they died 
            respawn.deathRespawn();
            deathAudio.GetComponent<AudioSource>().Play(); //When object is destroyed, play sound
            timer1 = 0; //When player dies, the point removal system resets
            timer2 = 0; //When player dies, the first ten points are returned 
        }

        
    }
}
