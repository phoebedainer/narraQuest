using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 35f;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 1.5f;
    private Rigidbody2D rb;


    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        //jump code
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;

        }
        if (controller.isGrounded() == false)
        {
            runSpeed = 20f;
        }
        else
        {
            runSpeed = 35f;
        }
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if(rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
        

        //crouch code
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;

        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
       
    }
   
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        
    }
    public float getRunSpeed()
    {
        return runSpeed;
    }
    public float getHorizMove()
    {
        return horizontalMove;
    }
}
    
 