//Made by Joel Draper for MansionGaming
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class RespawnBasicsAndroid : MonoBehaviour {

    public Text text; //Allows us to display respawns (just to make sure it is working) 

    public float respawnDelay; //Easy input of time to wait before respawn

    public GameObject currentCheckpoint;
    public GameObject gameOverCanvas;
    public GameObject gameCanvas;
    public GameObject achievementCanvas;
    public GameObject respawnGUI;

    public ScoreBasicsAndroid scoreM;
    public HealthBasicsAndroid healthB;
    public HealthAddonAndroid healthAdd;
    public PlayerFunctionsAndroid playerF;
    public AudioManager audioM;

    public GameObject player;

    public int respawnsLeft;
    public int timesDied; 

    public bool playerDead;

    void Awake()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.allowPrecache = true;
            Advertisement.Initialize("42576", false);
        }
        else
        {
            Debug.Log("Platform not supported");
        }
    }

	void Start () { 
        text.text = respawnsLeft.ToString();

        respawnsLeft = PlayerPrefs.GetInt("respawnsLeft", 0);

        if (respawnsLeft < 0)
        {
            respawnsLeft = 0;
            Debug.Log("respawns reset");
        }
    }

    void Update() {
        timesDied = PlayerPrefs.GetInt("timesDied", 0);

        if (playerDead)
        {
            timesDied += 1;
            //playerF.canJump = false;
            audioM.muteAudio = true;
            playerF.isActive = false;
            gameCanvas.SetActive(false);
            achievementCanvas.SetActive(false);
            respawnGUI.SetActive(false);
            scoreM.deathScore = scoreM.score;
            Time.timeScale = 0f;
            Advertisement.Show(null, new ShowOptions
            {
                pause = true,
                resultCallback = result =>
                {
                    Debug.Log("ad is shown");
                    gameOverCanvas.SetActive(true);
                }
            });
        }

        text.text = respawnsLeft.ToString();
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("respawnsLeft", respawnsLeft);
        PlayerPrefs.SetInt("timesDied", timesDied);
        scoreM.score = scoreM.deathScore;
    }

    public void deathRespawn()
    {
        if (respawnsLeft > 0)
        {
            respawnGUI.SetActive(true);
            gameCanvas.SetActive(false);
            //playerF.isActive = false;
            playerF.jumpFloat = 0;
            Time.timeScale = 0f;
        }
        if (respawnsLeft <= 0)
        {
            playerDead = true;
        }
    }

    public void respawnButton()
    {
        Time.timeScale = 1f;
        respawnGUI.SetActive(false);
        playerF.playerBool = 0;
        Debug.Log("player respawned");
        player.transform.position = currentCheckpoint.transform.position;
        StartCoroutine(respawnPlayer()); //When player dies, the coroutine plays 
    }

    public void quitButton()
    {
        respawnGUI.SetActive(false);
        Debug.Log("player died");
        playerDead = true;
    }

    IEnumerator respawnPlayer()
    {
        healthB.isActive = false;
        scoreM.isActive = false;
        scoreM.score -= 30; //When player respawns, they lose 30 score points
        healthAdd.resetHealth();
        yield return new WaitForSeconds(respawnDelay);
        respawnsLeft -= 1; //When the player dies, they lose a respawn
    }
}
