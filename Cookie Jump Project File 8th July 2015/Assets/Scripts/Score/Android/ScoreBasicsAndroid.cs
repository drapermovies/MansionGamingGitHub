//Made by Joel Draper for MansionGaming
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreBasicsAndroid : MonoBehaviour {

    public Text text; //Allows us to display the score
    public Text text1; //Allows us to display the high score
    public Text text2; //Allows us to display score when the player wants to respawn
    public Text text3; //Allows us to display the high score when the player dies
    public Text text4; //Allows us to display the death score when the player dies 

    public GameObject goldMedal;
    public GameObject silverMedal;
    public GameObject bronzeMedal;

    public int goldMedalInt;
    public int silverMedalInt;
    public int bronzeMedalInt;

    public int score;
    public int highScore;
    public int deathScore;
    private int scoreIncrease;

    public float timer = 0; //Timer for score
    public float timer1 = 0; //Timer for checking whether 10 seconds has passed
    public float timer2 = 0; //Timer for increasing every 10 seconds 

    public bool isActive;

    public achievementManagerAndroid achievement;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore", 0); //Retrieves high score, default 0
        text.text = score.ToString(); //Text to display score
        text1.text = highScore.ToString(); //Text to display high score
        goldMedalInt = PlayerPrefs.GetInt("goldMedalInt", 0);
        silverMedalInt = PlayerPrefs.GetInt("silverMedalInt", 0);
        bronzeMedalInt = PlayerPrefs.GetInt("bronzeMedalInt", 0);

        //Debug.Log("has been called");
    }

    public void Update()
    {
        text.text = score.ToString();
        text1.text = highScore.ToString();
        text2.text = score.ToString();
        text3.text = highScore.ToString(); //Text to display high score on death
        text4.text = deathScore.ToString(); //Text to display death score on death 

        if (!isActive)
        {
            if (Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    isActive = true;
                }
            }
        }

        if (isActive)
        {
            //Debug.Log("score is Active");

            timer += Time.deltaTime; //Starts the timer which updates the score every second 
            timer1 += Time.deltaTime; //Starts first timer
            timer2 += Time.deltaTime; //Starts second timer

            if (timer > 1) // has 1 second passed?
            {
                text.text = score.ToString();
                text1.text = highScore.ToString();
                score = score + scoreIncrease; //Points increase per a second equal to previous increase + 1
                timer = 0; //Timer resets
            }
            if (timer1 < 10)
            {
                scoreIncrease = 1; //If less then 10, score only increase by 1 every second 
            }
            if (timer2 >= 10)
            {
                scoreIncrease = scoreIncrease + 1; //Every ten seconds, the score increase increases by 1
                timer2 = 0; //The timer resets every ten seconds
            }
        }

        if (score > 100)
        {
            bronzeMedalInt = 1;
            achievement.BronzeBool = true;
        }

        if (score > 250)
            silverMedalInt = 1;

        if (score > 500)
            goldMedalInt = 1;

        if (bronzeMedalInt == 1)
        {
            bronzeMedal.SetActive(true);
            silverMedal.SetActive(false);
            goldMedal.SetActive(false);
        }
        if (silverMedalInt == 1)
        {
            bronzeMedal.SetActive(false);
            silverMedal.SetActive(true);
            goldMedal.SetActive(false);
        }
        if (goldMedalInt == 1)
        {
            bronzeMedal.SetActive(false);
            silverMedal.SetActive(false);
            goldMedal.SetActive(true);
        }


        if (score < 0)
            score = 0; //Score cannot be lower then 0

        if (deathScore >= highScore)
        {
            highScore = deathScore; //If the death score is more then the high score, the death score becomes the high score 
        }
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("highScore", highScore); //Sets high score
        PlayerPrefs.SetInt("deathScore", deathScore); //Sets death score
        PlayerPrefs.SetInt("goldMedalInt", goldMedalInt);
        PlayerPrefs.SetInt("silverMedalInt", silverMedalInt);
        PlayerPrefs.SetInt("bronzeMedalInt", bronzeMedalInt);
    }
}
