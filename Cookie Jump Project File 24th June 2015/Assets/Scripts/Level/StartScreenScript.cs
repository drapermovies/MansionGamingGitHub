//Made by Joel Draper for MansionGaming.
using UnityEngine;
using System.Collections;

public class StartScreenScript : MonoBehaviour {

	static bool sawOnce = false;
    static bool fellOnce = false;

    public buttons button;

    public GameObject guiCanvas;

	// Use this for initialization
	void Start () {
		if(!sawOnce && !fellOnce) {
			GetComponent<SpriteRenderer>().enabled = true;
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
                    guiCanvas.SetActive(true);
                    fellOnce = true;
                    Debug.Log("fell once");
                }
            }
		}
	}
}
