/*ECHO NITE 
* Joan Karstrom
* Chapman ID: 2318286
* Email: Karstrom@chapman.edu
* Player Move Script*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    /*Member variable declaration
     * playerSpeed: speed of player
     * facingRight: if player is facing right
     * playerJumpPower: how high the player can jump 
     * moveX: How much the player is to move*/
    public int playerSpeed = 10;
    private bool facingRight = false;
    public int playerJumpPower = 1250;
    private float moveX;
    public Animator animator;


	// Update is called once per frame
	void Update () {
		PlayerMover();
	}

    /*PlayerMover function
     * returns nothing
     * no parameters
     * no exceptions thrown*/
    void PlayerMover()
    {
        //controls
        moveX = Input.GetAxis("Horizontal");

        animator.SetFloat("Speed", Mathf.Abs(moveX));

        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }
                //animations
        //player direction
        if(moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if(moveX > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        //physics
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);  
    }

    /*Jump function
     * returns nothing
     * no parameters
     * no exceptions thrown*/
    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce (Vector2.up * playerJumpPower);
    }

    /*FlipPlayer function
     * returns nothing
     * no parameters
     * no exceptions thrown*/
    void FlipPlayer()
    {
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
