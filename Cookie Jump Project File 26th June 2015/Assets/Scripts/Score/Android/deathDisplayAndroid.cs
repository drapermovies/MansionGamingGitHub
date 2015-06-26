//Created by Joel Draper for MansionGaming.
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class deathDisplayAndroid : MonoBehaviour {

    public ScoreBasicsAndroid score;

    public Text text; //Allows us to display the final score once the player died 

    void Update ()
    {
        text.text = score.deathScore.ToString(); //displays death score
    }
}
