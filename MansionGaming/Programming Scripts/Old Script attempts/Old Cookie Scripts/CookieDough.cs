using UnityEngine;
using System.Collections;

public class CookieDough : MonoBehaviour {

    public HealthSystem health;

    private bool isActive = false; 

	void Start () {
	
	}

    void OnTriggerEnter2D(Collider2D other){
    if(isActive == false)
    {
        health.cookieHealth();
        isActive = true;
    }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        isActive = false;
    }

	void Update () {
	
	}
}
