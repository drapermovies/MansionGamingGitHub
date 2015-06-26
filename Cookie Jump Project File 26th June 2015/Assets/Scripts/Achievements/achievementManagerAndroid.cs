//Made by Joel Draper for MansionGaming
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class achievementManagerAndroid : MonoBehaviour {

    public Text text;
    public Text text1;
    public Text achievPerc;
    public Text achievEarn;
    public Text achiev1Name;
    public Text achiev1Desc;
    public Text achiev2Name;
    public Text achiev2Desc;
    public Text achiev3Name;
    public Text achiev3Desc;

    public GameObject achiev1Pic;
    public GameObject achiev2Pic;
    public GameObject achiev3Pic;

    private float timer = 0;

    public GameObject achievementCanvas;
    public GameObject AchievSFX;

    private string achievementName;
    public float achievDisplayTime;
    private string achievementReward;
    private string achievementDesc;
    public float totalAchievements;
    public float achievementsEarned;
    public float achievementPercentage;
    private float timesAchieved;
    private float timesAchieved1;

    private float achiev1b;
    private float achiev2b;
    public float spenderB;
    private float achiev4b;
    private float achiev6b;
    private float achiev7b;
    private float achiev8b;
    private float achiev9b;

    public ScoreBasicsAndroid score;
    public coinManager coin;
    public RespawnBasicsAndroid respawn;

    private bool completionist = false;
    private bool achiev1 = false;
    private bool achiev2 = false;
    private bool spender = false;
    private bool achiev4 = false;
    private bool achiev5 = false;
    private bool achiev6 = false;
    private bool achiev7 = false;
    private bool achiev8 = false;
    private bool achiev9 = false;

	void Start () {
        achievementPercentage = PlayerPrefs.GetFloat("achievementPercentage", 0);
        achievementsEarned = PlayerPrefs.GetFloat("achievementsEarned", 0);
        achiev1b = PlayerPrefs.GetFloat("achiev1b", 0);
        achiev2b = PlayerPrefs.GetFloat("achiev2b", 0);
        spenderB = PlayerPrefs.GetFloat("spenderB", 0);
        achiev4b = PlayerPrefs.GetFloat("achiev4b", 0);
        achiev6b = PlayerPrefs.GetFloat("achiev6b", 0);
        achiev7b = PlayerPrefs.GetFloat("achiev7b", 0);
        achiev8b = PlayerPrefs.GetFloat("achiev8b", 0);
        achiev9b = PlayerPrefs.GetFloat("achiev9b", 0);
        timer = PlayerPrefs.GetFloat("timer", 0);
        timesAchieved = PlayerPrefs.GetFloat("timesAchieved", 0);
        timesAchieved1 = PlayerPrefs.GetFloat("timesAchieved1", 0);
    }
	
	void Update () {
        achievPerc.text = achievementPercentage.ToString();
        achievEarn.text = achievementsEarned.ToString();

        timer += Time.deltaTime; //Starts timer

        if (achievementPercentage > 100)
        {
            achievementPercentage = 100;
        }
        if (achiev1b == 1)
        {
            achiev1 = true;
        }
        if (achiev2b == 1)
        {
            achiev2 = true;
        }
        if (spenderB == 1)
        {
            spender = true;
        }
        if (achiev4b == 1)
        {
            achiev4 = true;
        }
        if (achiev6b == 1)
        {
            achiev6 = true;
        }
        if (achiev7b == 1)
        {
            achiev7 = true;
        }
        if (achiev8b == 1)
        {
            achiev8 = true;
        }
        if (achiev9b == 1)
        {
            achiev9 = true;
        }

        if (totalAchievements == achievementsEarned)
        {
            Debug.Log("Completionist earned");
            achievementName = "Completionist";
            achievementDesc = "Get all other achievements";
            achievementReward = "50 gold coins";
            coin.gold += 50;
            StartCoroutine(achievement());
            completionist = true;
        }

        if (score.score > 20 && !achiev1)
        {
            achiev1b = 1;
            Debug.Log("achievement 1 achieved"); 
            achievementName = "Twenty is Plenty";
            achievementDesc = "Get 20 points in a single run";
            achievementReward = "5 gold coins";
            coin.gold += 5;
            StartCoroutine (achievement());
            achievementsEarned += 1;
            Debug.Log("achievements earned = " + achievementsEarned);
            achievementPercentage += 12.5f;
        }
        if (achiev1)
        {
            achiev1Name.text = "Twenty is Plenty";
            achiev1Desc.text = "Get 20 points in a single run";
            achiev1Pic.SetActive(true);
        }
        if(score.score > 50 && !achiev2)
        {
            achiev2b = 1;
            Debug.Log("achievement 2 achieved");
            achievementName = "Half century";
            achievementDesc = "Get 50 points in a single run";
            achievementReward = "10 gold coins";
            coin.gold += 10;
            StartCoroutine(achievement());
            achievementsEarned += 1;
            Debug.Log("achievements earned = " + achievementsEarned);
            achievementPercentage += 12.5f;
        }
        if (achiev2)
        {
            achiev2Name.text = "Half century";
            achiev2Desc.text = "Get 50 points in a single run";
            achiev2Pic.SetActive(true);
        }
        if(spender && timesAchieved == 0)
        {
            timesAchieved += 1;
            Debug.Log("achievement 3 achieved");
            achievementName = "Spender";
            achievementDesc = "Use the store for the first time.";
            achievementReward = " ";
            StartCoroutine(achievement());
            achievementsEarned += 1;
            Debug.Log("achievements earned = " + achievementsEarned);
            achievementPercentage += 12.5f;
            achiev3Name.text = "Spender";
            achiev3Desc.text = "Use the store for the first time";
            achiev3Pic.SetActive(true);
        }
        if (score.timer1 > 60 && !achiev4)
        {
            Debug.Log("achievement 4 achieved");
            achievementName = "Minute man";
            achievementDesc = "Survival for 60 seconds or more without dying or respawning";
            achievementReward = "10 gold coins";
            coin.gold += 10;
            StartCoroutine(achievement());
            achievementsEarned += 1;
            Debug.Log("achievements earned = " + achievementsEarned);
            achievementPercentage += 12.5f;
        }
        if (respawn.timesDied == 1)
        {
            Debug.Log("achievement 5 achieved");
            achievementName = "This ain't dark souls";
            achievementDesc = "Die for the first time";
            achievementReward = "1 respawn";
            respawn.respawnsLeft += 1;
            StartCoroutine(achievement());
            achiev5 = true;
            achievementsEarned += 1;
            Debug.Log("achievements earned = " + achievementsEarned);
            achievementPercentage += 12.5f;
        }
        if (timer > 300 && !achiev6)
        {
            achiev6b = 1;
            Debug.Log("achiev 6 should be true");
            Debug.Log("achievement 6 earned");
            achievementName = "Long road ahead";
            achievementDesc = "Play for more then 5 minutes total";
            achievementReward = "2 coins";
            coin.gold += 2;
            StartCoroutine(achievement());
            achievementsEarned += 1;
            Debug.Log("achievements earned = " + achievementsEarned);
            achievementPercentage += 12.5f;
        }
        if(achievementPercentage == 100 && timesAchieved1 == 0){
            timesAchieved1 += 1;
            Debug.Log("achievement 7 earned");
            achievementName = "99...ONE HUNDRED!";
            achievementDesc = "Get 100% game completion";
            achievementReward = "25 coins";
            coin.gold += 25;
            StartCoroutine(achievement());
            achiev7b = 1;
            achievementsEarned += 1;
            Debug.Log("achievements earned = " + achievementsEarned);
        }
        if (timer == 3600 && !achiev8) 
        {
            Debug.Log("achievement 8 earned");
            achievementName = "Addict";
            achievementDesc = "Play for more then one hour in total";
            achievementReward = "5 coins";
            coin.gold += 5;
            StartCoroutine(achievement());
            achiev8 = true;
            achievementsEarned += 1;
            Debug.Log("achievements earned = " + achievementsEarned);
            achievementPercentage += 12.5f;
        }
        if (timer == 86400 && !achiev9)
        {
            Debug.Log("achievement 9 earned");
            achievementName = "All day player";
            achievementDesc = "Play for more then one day in total";
            achievementReward = "15 coins";
            coin.gold += 15;
            StartCoroutine(achievement());
            achiev9 = true;
            achievementsEarned += 1;
            Debug.Log("achievements earned = " + achievementsEarned);
            achievementPercentage += 12.5f;
        }
	}

    IEnumerator achievement()
    {
        Debug.Log("achievement coroutine started");
        achievementCanvas.SetActive(true);
        AchievSFX.GetComponent<AudioSource>().Play();
        text.text = achievementName;
        text1.text = achievementReward;
        yield return new WaitForSeconds(achievDisplayTime);
        achievementCanvas.SetActive(false);
        AchievSFX.GetComponent<AudioSource>().Stop();
        Debug.Log("achievement audio should stop");
        StopCoroutine (achievement());
        Debug.Log("coroutine stopped");
    }

    void OnDestroy()
    {
        PlayerPrefs.SetFloat("achievementPercentage", achievementPercentage);
        PlayerPrefs.SetFloat("achievementsEarned", achievementsEarned);
        PlayerPrefs.SetFloat("timer", timer);
        PlayerPrefs.SetFloat("achiev1b", achiev1b);
        PlayerPrefs.SetFloat("achiev2b", achiev2b);
        PlayerPrefs.SetFloat("spenderB", spenderB);
        PlayerPrefs.SetFloat("achiev4b", achiev4b);
        PlayerPrefs.SetFloat("achiev6b", achiev6b);
        PlayerPrefs.SetFloat("achiev7b", achiev7b);
        PlayerPrefs.SetFloat("achiev8b", achiev8b);
        PlayerPrefs.SetFloat("achiev9b", achiev9b);
        PlayerPrefs.SetFloat("timesAchieved", timesAchieved);
        PlayerPrefs.SetFloat("timesAchieved1", timesAchieved1);
    }
}
