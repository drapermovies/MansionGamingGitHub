//Created by Joel Draper for MansionGaming, 2015. 
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour {

    public static int score;

    Text text;

    public bool done = false; 

    void Start(){
        text = GetComponent<Text>();

        score = 0;
    }

    public void Update() {
        if (score < 0)
            score = 0;

        text.text = "" + score;

        if (done = false) {
            if (Input.GetMouseButtonDown(0))
                StartCoroutine("PointsSystem");
        }
}

    public IEnumerator PointsSystem() {
        while (true)
        {
            yield return new WaitForSeconds(1);
            score += 1;
        }
    }

    public static void AddPoints(int PointsToAdd)
    {
        score += PointsToAdd;
    }
}