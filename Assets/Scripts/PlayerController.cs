using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;
    public float runSpeed = 7;
    public float jumpForce = 10;
    public Rigidbody2D rb;
    public Animator anim;
    public SpriteRenderer spriteRenderer;

    public GroundChecker groundChecker;
    public PlayerStats stats;
    public Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        stats = GetComponent<PlayerStats>();
        inventory = GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stats.isDead) return;

        float moveInput = Input.GetAxis("Horizontal");
        //Debug.Log($"Input pressed: {moveInput}");

        if (moveInput < 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }

        if (moveInput != 0)
        {
            anim.SetBool("isWalking",true);
        }
        else
        {
            anim.SetBool("isWalking",false);
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            rb.velocity = new Vector2(moveInput * runSpeed, rb.velocity.y);
        }
        else
        { 
            rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.Space) && groundChecker.isGrounded)
        {
            //rb.AddForce(new Vector2(0,jumpForce));
            rb.AddForce(Vector2.up * jumpForce);
            anim.SetBool("isJumping", true);
            //isJump = true
            // Invoke ( ShouldCheckJumpEnd, 1 )
            return;
        }

        if (rb.velocity.y < 0)
        {
            anim.SetBool("isFalling", true);
        }

            if (groundChecker.isGrounded == true) // && is Jump == false
        {
            anim.SetBool("isJumping", false);
            anim.SetBool("isFalling", false);
        }    

    }

    //void ShouldCheckJumpEnd () => isJump = false;
}
