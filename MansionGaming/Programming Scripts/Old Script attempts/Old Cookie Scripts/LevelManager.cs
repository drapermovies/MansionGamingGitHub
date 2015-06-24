//Created by Joel Draper for MansionGaming. 
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public HealthSystem healthSystem;

    public RespawnManager respawn;

    public Player player; 

    public GameObject currentCheckpoint;

    public int pointPenaltyOnDeath;

    public float respawnDelay;

    public GameObject other;

    Text text; 

    void Start()
    {
        player = FindObjectOfType<Player>();
        text = GetComponent<Text>();
    }

    void Update()
    {

    }

    public void playerDeath()
    {
      
    }

    public void RespawnPlayer()
    {
        StartCoroutine("RespawnPlayerCo");
        healthSystem.resetHealth();
    }

    public IEnumerator RespawnPlayerCo()
    {
        /*
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        other.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(respawnDelay);
        player.transform.position = currentCheckpoint.transform.position;*/
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        other.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(respawnDelay);
        player.transform.position = currentCheckpoint.transform.position;
        healthSystem.resetHealth(); // <-- Put it here
    }
}