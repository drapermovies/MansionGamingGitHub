//Created by Joel Draper for MansionGaming.
using UnityEngine;
using System.Collections;

public class logoScene : MonoBehaviour {

    public float timer = 0;

	void Start () {
        StartCoroutine(sceneLogo());
	}

    void Update ()
    {
        StartCoroutine(sceneLogo());

        timer += Time.deltaTime; //Starts timer

        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Application.LoadLevel(1);
            }
        }
    }

    IEnumerator sceneLogo()
    {
        yield return new WaitForSeconds(5);
        Application.LoadLevel(1);
    }

}
