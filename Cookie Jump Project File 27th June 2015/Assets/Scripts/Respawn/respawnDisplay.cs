//Made by Joel Draper for MansionGaming
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class respawnDisplay : MonoBehaviour {

    public Text text; //Allows us to display respawns (just to make sure it is working) 

    public RespawnBasics respawn;

    public int respawnsLeft;

	// Use this for initialization
	void Start () {
        respawnsLeft = respawn.respawnsLeft;
        text.text = respawnsLeft.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = respawnsLeft.ToString(); text.text = respawnsLeft.ToString();
	}

    void OnDestroy()
    {
        respawn.respawnsLeft = respawnsLeft;
    }
}
