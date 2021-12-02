using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
   

    public float speed = 5f, jumpVelocety , jumpwaitTime;
    Rigidbody2D rb;
    bool facingRight;
    public bool isGrounded = false; 
    public KeyCode jumpkey;
    public Animator animator;
    public LayerMask ground;
    public Collider2D footCollider;
    public Joystick joystick;

    private float jumpWaitTimer;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

      float move = Input.GetAxisRaw("Horizontal"); //this is for pc controler

        // float move = joystick.Horizontal * speed; //this for joystick countroler

        isGrounded = footCollider.IsTouchingLayers(ground);

        animator.SetFloat("Speed", Mathf.Abs(move));

        rb.velocity = new Vector2(move * speed, rb.velocity.y);
      
        if (move > 0 && facingRight)
        {
            flip();
        }
        else if(move < 0 && !facingRight)
        {
            flip();
        }
        
       
        if(Input.GetKeyDown(jumpkey) )
        {
            
           
            if (isGrounded || jumpWaitTimer >0f)
            {    
                jump();
            }
             
        }
        if (isGrounded)
        {
            animator.SetBool("isJumping", false);
            jumpWaitTimer = jumpwaitTime;
        }
        else
        {
            animator.SetBool("isJumping", true);
            if (jumpWaitTimer >0f )
            {
                jumpWaitTimer -= Time.deltaTime;
            }
        }

    }

    /*public void Moving()
    {
        float move = joystick.Horizontal * speed;
        animator.SetFloat("Speed", Mathf.Abs(move));

        rb.velocity = new Vector2(move * speed, rb.velocity.y);

        if (move > 0 && facingRight)
        {
            flip();
        }
        else if (move < 0 && !facingRight)
        {
            flip();
        }
    }

   public void Jumping()
    {
        isGrounded = footCollider.IsTouchingLayers(ground);
        if (isGrounded || jumpWaitTimer > 0f)
        {

            jump();
        }

        if (isGrounded)
        {
            animator.SetBool("isJumping", false);
            jumpWaitTimer = jumpwaitTime;
        }
        else
        {
            animator.SetBool("isJumping", true);
            if (jumpWaitTimer > 0f)
            {
                jumpWaitTimer -= Time.deltaTime;
            }
        }


    }*/




    void flip()
    {
        facingRight = !facingRight; // if true it will be fals if fals true // yes coding
        transform.Rotate(0f, 180f, 0f);
    }

    void jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpVelocety * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("monster") )
        {
            PlayerPrefs.SetInt("coin amont", coinCointerSkript.coinAmont);
            coinCointerSkript.coinAmont = 0;
            SceneManager.LoadScene("Gameover");
        }
        

    }


}
