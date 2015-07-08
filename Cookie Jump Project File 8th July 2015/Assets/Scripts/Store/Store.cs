//Made by Joel Draper for MansionGaming
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Store : MonoBehaviour {

    public Text text; //Allows us to display the amount of coins collected
    //public Sprite []playerSkinNew;

    public coinManager coinManager;
    public RespawnBasics respawnManager;
    public achievementManager achievement;

    public void buyRespawn()
    {
        if (coinManager.gold > 0)
        {
            coinManager.gold -= 5;
            respawnManager.respawnsLeft += 1;
            achievement.spenderB = 1;
        }
        else
            return;
    }
    public void buyGold()
    {
        coinManager.gold += 1000;
    }

    public void back()
    {
        Application.LoadLevel(1);
    }

    public void loseRespawn()
    {
        respawnManager.respawnsLeft -= 1;
    }

    public void buySkin1()
    {
        //spriteRenderer.sprite = playerSkinNew;
    }
}
