using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    
    
    [SerializeField] float horizontalSpeed = 5f;
    [SerializeField] float jumpPower = 5f;
    [SerializeField] float dashPower = 5f;
    

    public static float movement;
    private int doubleJumpCounter = 2;
    private bool grounded = true;

    private bool canDash = true;
    private float  dashCoolDown = 1.5f;
    
    


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
              
    }


    private void Update()
    
    {
        SpriteRotation();
        CharacterMovement();
        
        
        

            
    }



    private void CharacterMovement()
    {
        movement = Input.GetAxis("Horizontal");
      
        transform.position += new Vector3(movement , 0 , 0) * horizontalSpeed/1000;

        if(gameObject.CompareTag("Ninja")){
            DoubleJump();

            if(Input.GetKeyDown(KeyCode.LeftShift) & canDash == true){
                StartCoroutine(Dash());
            }

            
            
        }
        else if(gameObject.CompareTag("Kid")){
            Jump();
            
            
        }
        







        
        
    }
    IEnumerator Dash(){

        canDash = false;
        float dashPowerTemp = dashPower * Input.GetAxisRaw("Horizontal");
        
        rb.velocity = new Vector2(dashPowerTemp , 0f);
        
        yield return new WaitForSeconds(dashCoolDown);
        canDash = true;


        
        
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
