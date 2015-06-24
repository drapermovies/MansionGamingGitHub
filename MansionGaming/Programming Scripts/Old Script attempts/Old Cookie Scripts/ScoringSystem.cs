//Created by Joel Draper for MansionGaming, 2015. 
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour {

    public static int score;

    Text text;

    private bool done = false;

    public bool isCoin = false;
    public bool isSpikeEnd = false;
    public bool isDough = false;
    private bool isActive = false;

    void Start(){
        text = GetComponent<Text>();

        score = 0;
    }

    public void Update() {
        if (score < 0)
            score = 0;

        text.text = "" + score;

        if (done == false) 
        {
            if (Input.GetMouseButtonDown(0))
            {
                StartCoroutine("PointsSystem");
                done = true;
            }
        }
}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (isActive == false)
        {
            if (isCoin == true)
            {
                score += 50;
                isActive = true;
                Destroy(gameObject);
            }

            if (isSpikeEnd == true)
            {
                score += 3;
                isActive = true;
            }

            if (isDough == true)
            {
                score += 5;
                isActive = true;
                Destroy(gameObject);
            }
        }
    }

   public void respawnPenalty()
    {
        score -= 30;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        isActive = false; 
    }

    public IEnumerator PointsSystem() {
        while (true)
        {
            yield return new WaitForSeconds(1);
            score += 1;
        }
    }
}