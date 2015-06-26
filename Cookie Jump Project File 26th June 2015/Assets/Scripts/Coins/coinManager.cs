//Made by Joel Draper for MansionGaming 
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class coinManager : MonoBehaviour {

    public Text text; //Allows us to display the amount of coins collected

    public int gold; //Used as integer for coins collected

    void Start()
    {
        text.text = gold.ToString(); //At start of game, display gold 

        gold = PlayerPrefs.GetInt("gold", 0);
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("gold", gold);
    }

    void Update()
    {
        text.text = gold.ToString(); //Update gold shown on screen every time 
    }
}
