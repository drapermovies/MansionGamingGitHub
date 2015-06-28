//Created by Joel Draper for MansionGaming.
using UnityEngine;
using System.Collections;

public class logoScene : MonoBehaviour {

    public float timer = 0;

	void Start () {
        StartCoroutine(sceneLogoPC());
	}

    void Update ()
    {
        //StartCoroutine(sceneLogoPC());

        timer += Time.deltaTime; //Starts timer

        if (Input.GetMouseButtonDown(0)){
                Application.LoadLevel(1);
            }
        }

    IEnumerator sceneLogoPC()
    {
        yield return new WaitForSeconds(5);
        Application.LoadLevel(1);
    }

}
