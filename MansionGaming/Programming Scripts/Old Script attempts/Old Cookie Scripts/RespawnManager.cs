//Created by Joel Draper for MansionGaming.
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RespawnManager : MonoBehaviour {

    public LevelManager levelManager;
    public ScoringSystem score;

    public static int respawnsLeft;

    Text text;

	void Start () {
        text = GetComponent<Text>();

        respawnsLeft = 1;
	}
	
	void Update () {
        if (respawnsLeft < 0)
            Application.LoadLevel(1);

        text.text = "" + respawnsLeft;
	}

    public void deathRespawn(){
        respawnsLeft -= 1;

        score.respawnPenalty();
    }

}
