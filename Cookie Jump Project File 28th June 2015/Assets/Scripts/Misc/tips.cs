//Made by Joel Draper for MansionGaming.
using UnityEngine;
using System.Collections;
//using System.Collections.Generic;
using UnityEngine.UI;

public class tips : MonoBehaviour {

    public Text tip;

    string currentTip;

    void Start()
    {

        string[] tipString = new string[5]{
            "Tip: You survive longer if you're bigger.", "Tip: The more cookie dough you collect, the larger you get.", "Tip: You don't have to pay for gold, you can earn it in game.", "Tip: You should build an android game for Android to get use to hardware constraints.", "Tip: You can buy respawns for a longer playtime."
        };

         currentTip = tipString[Random.Range(0, tipString.Length)]; 
    }

    void Update() {
             tip.text = currentTip;
    }
}