using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{

    public Text text;
    public bool isPlayer = false;

    public RespawnManager respawn;
    public LevelManager levelManager;

    private int health = 100;
    private float timer = 0;
    private float Scale, lastScale = 1f;


    void Start()
    {
        text.text = health.ToString();
        CheckHealth();

#if UNITY_EDITOR
        // enable Update() while the game is not in focus,
        // only for Testing in the editor.
        // Any code inside #UNITY_EDITOR will not be present when you ship the game.
        Application.runInBackground = true;
#endif
    }

    void Update()
    {
        /*timer += Time.deltaTime;

        if (timer > 1) // has 1 second passed?
        {
            text.text = health.ToString();
            CheckHealth();
            health -= 1;
            timer = 0;

            if (health <= 0)
            {
                levelManager.RespawnPlayer();
                respawn.deathRespawn();
                health = 100;
            }
        }*/

        timer += Time.deltaTime;
        CheckHealth();

        if (health <= 0)
        {
            levelManager.RespawnPlayer();
            respawn.deathRespawn();
            health = 100; // Also to note- This won't be necessary, cause you're already resetting the health in the respawn function.
        }

        if (timer > 1) // has 1 second passed?
        {
            text.text = health.ToString();

            health -= 1;
            timer = 0;
        }
    }

    void CheckHealth()
    {
        if (isPlayer)
        {
            if (health < 10)
                Scale = 1f;
            else if (health < 20)
                Scale = 2f;
            else if (health < 30)
                Scale = 3f;
            else if (health < 40)
                Scale = 4f;
            else if (health < 50)
                Scale = 5f;
            else if (health < 60)
                Scale = 6f;
            else if (health < 70)
                Scale = 7f;
            else if (health < 80)
                Scale = 8f;
            else if (health < 90)
                Scale = 9f;
            else if (health < 100)
                Scale = 10f;
            else if (health >= 100)
                Scale = 11f;

            /*if (Scale != lastScale) // small optimization to prevent setting the transform each frame
            {
                transform.localScale = new Vector3(Scale, Scale, Scale);
                lastScale = Scale;
            }*/
        }
    }

    public void cookieHealth()
    {
        health += 25;
    }

    public void spikeDamage()
    {
        health -= 5;
    }

    public void TakeDamage(float Damage) {
        health -= Mathf.Abs((int)Damage); 
    }


    public void resetHealth()
    {
        health = 100;
    }
 
}