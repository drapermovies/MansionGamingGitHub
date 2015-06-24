//Created by Joel Draper for MansionGaming, 2015 
using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public RespawnManager respawn;

    private int jumpHeight;

    public Transform GroundCheck;
    public float GCRadius;
    public LayerMask WhatIsGround;
    private bool Grounded;

    public HealthSystem health;

    void Start() {
        GetComponent<Rigidbody2D>().gravityScale = 0;

        jumpHeight = 30;
    }

    void FixedUpdate()
    {

        Grounded = Physics2D.OverlapCircle(GroundCheck.position, GCRadius, WhatIsGround);
    }
	
	void Update () {

        if (Grounded)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody2D>().gravityScale = 10;
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
            }
        }
        if (!Grounded)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody2D>().gravityScale = 10;
            }
        }
	}
}
