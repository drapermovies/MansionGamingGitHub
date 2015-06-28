//Made by Joel Draper for MansionGaming.
using UnityEngine;
using System.Collections;

public class StartScreenScript : MonoBehaviour {

	public bool sawOnce = false;
    public bool fellOnce = false;

    public buttons button;

    public GameObject guiCanvas;
    public GameObject startGUI;

	// Use this for initialization
	void Start () {
		if(!sawOnce && !fellOnce) {
			GetComponent<SpriteRenderer>().enabled = true;
            startGUI.SetActive(true);
			Time.timeScale = 0;
            guiCanvas.SetActive(false);
		}

		sawOnce = true;
        Debug.Log("start screen started");
	}
	
	// Update is called once per frame
	void Update () {
        if (button.paused == false)
        {
            if (Input.GetMouseButtonDown(0) && !fellOnce)
            {
                Debug.Log("start screen fall");
                Time.timeScale = 1;
                GetComponent<SpriteRenderer>().enabled = false;
                startGUI.SetActive(false);

                guiCanvas.SetActive(true);
                fellOnce = true;
                Debug.Log("fell once");
            }
            if (Input.GetMouseButtonDown(0) && fellOnce)
            {
                Debug.Log("player has already fallen");
            }
        }
        if (button.paused == true)
        {
            Debug.Log("game is paused, -start screen");
        }
	}
}
