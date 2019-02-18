using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour {

    // Subscribe his channel

    
    
    
    //For Move
    public float speed;
    public float jumpFoce;
    private float moveInput;
    private Rigidbody2D rb;



    // For Flip
    private bool facingRight = true;

    // For layermask
    private bool isGrounded;
    public float checkRadius;
    public Transform groundCheck;
    public LayerMask Ground;


    // for jumps (double , triple)
    private int extraJumps;
    public int extraJumpValue;


	// Use this for initialization
	void Start () {
     
		rb = GetComponent<Rigidbody2D>();

        extraJumps = extraJumpValue;
    }

	
	// Update is called once per frame



    void FixedUpdate() {
        // for circle layer mask
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, Ground);       //(CirclePosition, size , layer )



        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);


        if (facingRight == false && moveInput > 0) {

            flip();
        }

        if (facingRight == true && moveInput < 0)
            flip();

    }


    void Update() {

        if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0) {

            rb.velocity = Vector2.up * jumpFoce;
            extraJumps--;

        }

        else if (isGrounded == true && Input.GetKeyDown(KeyCode.Space) && extraJumps == 0) 
        {

            rb.velocity = Vector2.up * jumpFoce;
        }

    }

    void flip() {

        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;                      // scale.x = 4         to scale.x =-4
        transform.localScale = Scaler;
    }
    
  /* // Die by being off screen
    Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
      if (screenPosition.y > Screen.height || screenPosition.y < 0)
      {
       Die();
      }
   
 
// Die by collision
    void OnCollisionEnter2D(Collision2D other)
    {
     Die();
    }
 
    void Die()
   {
    Application.LoadLevel(Application.loadedLevel);
   }
   * 
   * **/
   
    
    
    
    
    
    

}
