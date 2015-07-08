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

        string[] tipString = new string[14]{
            "Tip: You survive longer if you're bigger.", "The more cookie dough you collect, the larger you get.", "Tip: You don't have to pay for gold, you can earn it in game.", "Tip: You should build an Android game for Android to get used to the hardware constraints.", "Tip: You can buy respawns for a longer playtime.", "Different cookies have different abilities.", "Tip: Never work on a business project with friends. It only leads to pain.", "Tip: Avoid milk. Milk degrades your cookie faster.", "Your feedback is always appreciated.", "Feedback is better if given in a Written Document or Email.", "Bigger isn't always better.", "The store can be used to purchase upgrades and respawns.", "I. Am. Potato.", "Cheese is yummylicous."
        };

         currentTip = tipString[Random.Range(0, tipString.Length)]; 
    }

    void Update() {
             tip.text = currentTip;
    }
}