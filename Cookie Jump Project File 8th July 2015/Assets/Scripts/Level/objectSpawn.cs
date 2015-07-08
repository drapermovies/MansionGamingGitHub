//Made by Joel Draper for MansionGaming.
using UnityEngine;
using System.Collections;

public class objectSpawn : MonoBehaviour
{
    public GameObject spawn;
    public GameObject health;
    public GameObject milk;
    public GameObject coin;

    int pickedNum;

    void Start()
    {
        int[] randomNum = new int[3];
        randomNum[1] = 1;
        randomNum[2] = 2;
        randomNum[3] = 3;

        pickedNum = randomNum[Random.Range(0, randomNum.Length)]; 

        if (pickedNum == 1) {
           
        }
        else if (pickedNum == 2)
        {
            
        }
        else if (pickedNum == 3)
        {
            
        }

        Debug.Log(pickedNum);
    }

    void Update()
    {
        Debug.Log(pickedNum);
    }
}