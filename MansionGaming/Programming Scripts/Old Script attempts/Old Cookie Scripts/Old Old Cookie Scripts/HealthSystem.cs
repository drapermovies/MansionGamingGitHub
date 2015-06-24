//Created by Joel Draper for MansionGaming.
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{

    public LevelManager levelManager;

    public RespawnManager respawn;

    private int health;

    private bool done = false;

    public bool isPlayer = false;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();

        health = 100;

        text.text = " " + health;
    }

    public void resetHealth()
    {
        health = 100;
    }

    void Update()
    {
        if (health <= 0)
        {
            levelManager.RespawnPlayer();
            respawn.deathRespawn();
            health = 100;
        }

        text.text = health.ToString();
        if (health >= 100 && isPlayer == true)
        {
            transform.localScale = new Vector3(20f, 20f, 20f);
        }
        if (health < 100 && isPlayer == true)
        {
            transform.localScale = new Vector3(10f, 10f, 1f);
        }
        if (health < 80 && isPlayer == true)
        {
            transform.localScale = new Vector3(3f, 3f, 3f);
        }

        if (done == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                StartCoroutine("HealthDamage");
                done = true;
            }
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

    public IEnumerator HealthDamage()
    {
        while (true)
        {
            health -= 1;
            yield return new WaitForSeconds(1);

        }
    }
}