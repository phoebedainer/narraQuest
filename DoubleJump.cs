using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    public PlayerMovement mover;
    public CharacterController2D controller;
    public float jumpPower = 15f;
    public int extraJumps = 2;
    public int jumpCounter;


    // Update is called once per frame
    void Awake()
    {
        jumpCounter = extraJumps;
    }
    void Update()
    {
       
       
        
        if (Input.GetButtonDown("Jump") && jumpCounter > 0)
        {
            controller.Move(mover.getHorizMove() * Time.fixedDeltaTime, false, true);
            jumpCounter--;
        }
        if (controller.isGrounded())
        {
            jumpCounter = extraJumps;   
        }
    }
    public int getJumpCounter()
    {
        return jumpCounter;
    }
}
