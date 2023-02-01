using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    
    [SerializeField] float horizontalSpeed = 5f;
    [SerializeField] float jumpPower = 5f;
    public static float movement;
    private int doubleJumpCounter = 2;
    private bool grounded = true;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }


    private void Update()
    {
        CharacterMovement();
        SpriteRotation();
            
    }



    private void CharacterMovement()
    {
        movement = Input.GetAxis("Horizontal");
      
        transform.position += new Vector3(movement , 0 , 0) * horizontalSpeed/1000;

        if(gameObject.CompareTag("Ninja")){
            DoubleJump();
            
        }
        else if(gameObject.CompareTag("Kid")){
            Jump();
        }





        
        
    }


    private void Jump()
    {
        

        if(Input.GetKeyDown(KeyCode.Space) == true && grounded == true )
        {

            rb.velocity = new Vector2(movement , jumpPower);
            grounded = false;
            
        }

    }

    private void DoubleJump(){
        

        if(Input.GetKeyDown(KeyCode.Space) == true & doubleJumpCounter > 0)
        {

            rb.velocity = new Vector2(movement , jumpPower);
            doubleJumpCounter = doubleJumpCounter -1;
            
        }

    }
    void OnCollisionEnter2D(Collision2D col)
    {
      if(col.gameObject.tag == "Ground"){
        doubleJumpCounter = 2;
        grounded = true;
      }   
    }

    private void SpriteRotation()
   {
    
     if(Input.GetKeyDown(KeyCode.LeftArrow)){
        transform.localRotation = Quaternion.Euler(0, 180, 0);



     }
     else if(Input.GetKeyDown(KeyCode.RightArrow)){
        transform.localRotation = Quaternion.Euler(0, 0, 0);

    }

    
    
   }
}
