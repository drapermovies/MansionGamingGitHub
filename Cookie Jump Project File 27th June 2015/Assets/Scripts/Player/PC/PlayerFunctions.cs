//Made by Joel Draper for MansionGaming. 
using UnityEngine;
using System.Collections;

public class PlayerFunctions : MonoBehaviour {

    public bool isActive;
    public bool canJump = true;

    public float playerBool;
    public float jumpFloat;

    private int jumpHeight;
    public GameObject jumpSound;

    public buttons button;

    public Transform GroundCheck;
    public float GCRadius;
    public LayerMask WhatIsGround;
    private bool Grounded;

	void Start () {
        playerBool = PlayerPrefs.GetFloat("playerBool", 0);
        jumpFloat = PlayerPrefs.GetFloat("jumpFloat", 0);
        if (!isActive) { 
        GetComponent<Rigidbody2D>().gravityScale = 0; //Player floats at the beginning of the game
        }
	}

    void FixedUpdate()
    {
        Grounded = Physics2D.OverlapCircle(GroundCheck.position, GCRadius, WhatIsGround); //It checks these every frame
    }

    void Update() {
        if (jumpFloat == 1)
        {
            Debug.Log("player can jump");
            canJump = true;
        }
        if (jumpFloat == 0)
        {
            Debug.Log("player cannot jump");
            canJump = false;
        }
        if(playerBool == 1)
        {
            Debug.Log("PLAYER IS ACTIVE");
            isActive = true; 
        }
        if(playerBool == 0)
        {
            isActive = false;
            Debug.Log("PLAYER IS NOT ACTIVE");
        }

        if(!isActive)
        {
             if (Input.GetMouseButtonDown(0)){
                    if (button.paused == false)
                    {
                        playerBool = 1;
                    }
                }
          }

       if (isActive) {
              Debug.Log("Player is active");
              jumpHeight = 20;  //Player jump height
              GetComponent<Rigidbody2D>().gravityScale = 7; //On first mouse down, Player falls - Gravity Scale is scale of Gravity
              if (Grounded)
              {
                  if (canJump)
                  {
                      if (Input.GetMouseButtonDown(0))
                      {
                          Debug.Log("player has jumped");
                          GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight); //On mouse down, player jumps
                          jumpSound.GetComponent<AudioSource>().Play(); //When player jumps, play sound 
                      }
                  }
              }
              if (!Grounded)
              {
                  jumpFloat = 1;
                  canJump = false;
                  Debug.Log("player is not grounded");
                  if (Input.GetMouseButtonDown(0))
                  {
                      Debug.Log("player should not jump");
                      GetComponent<Rigidbody2D>().gravityScale = 10; //If player has already jumped, they cannot jump again 
                  }
              }
            }
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("playerBool", 0);
        PlayerPrefs.SetInt("jumpFloat", 0);
    }
}
