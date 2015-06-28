//Made by Joel Draper for MansionGaming.
using UnityEngine;
using System.Collections;

public class StartScreenScriptAndroid : MonoBehaviour {

	public bool sawOnce = false;
    public bool fellOnce = false;

    public buttonsAndroid button;

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
	}
	
	// Update is called once per frame
	void Update () {
        if (button.paused == false) {
            if (Input.touchCount > 0)
            {
                if (Time.timeScale == 0 && (Input.GetTouch(0).phase == TouchPhase.Began) && !fellOnce)
                {
                    Debug.Log("start screen fall");
                    Time.timeScale = 1;
                    GetComponent<SpriteRenderer>().enabled = false;
                    startGUI.SetActive(false);
                    guiCanvas.SetActive(true);
                    fellOnce = true;
                    Debug.Log("fell once");
                }
            }
		}
	}
}
