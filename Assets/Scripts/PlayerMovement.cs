using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    
    
    [SerializeField] float horizontalSpeed = 5f;
    [SerializeField] float jumpPower = 5f;
    [SerializeField] float dashPower = 5f;
    [SerializeField] private TrailRenderer trail;
    [SerializeField] GameObject players;
    

    public static float movement;
    private int doubleJumpCounter = 2;
    private bool grounded = true;

    public static bool canDash = true;
    private float  dashCoolDown = 1.5f;
    private int pushPower = 3;
    
    


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        players = GameObject.FindGameObjectWithTag("Players");
        Debug.Log("Patates");
        
              
    }


    private void Update()
    
    {
        SpriteRotation();
        CharacterMovement();

        
        
        
        

            
    }



    private void CharacterMovement()
    {
        movement = Input.GetAxis("Horizontal");
      
        transform.position += new Vector3(movement , 0 , 0) * horizontalSpeed/2*Time.deltaTime;

        if(gameObject.CompareTag("Ninja")){
            DoubleJump();

            if(Input.GetKeyDown(KeyCode.LeftShift) & canDash == true){
                StartCoroutine(Dash());
            }

            
            
        }
        else if(gameObject.CompareTag("Kid")){
            Jump();
            canDash = true;
            
            
        }
        
    }
    IEnumerator Dash(){

        canDash = false;
        float dashPowerTemp = dashPower * Input.GetAxisRaw("Horizontal");
        
        rb.velocity = new Vector2(dashPowerTemp , 0f);
        trail.emitting = true;
        
        yield return new WaitForSeconds(dashCoolDown);
        canDash = true;
        trail.emitting = false;


        
        
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

            rb.velocity = new Vector2(movement , jumpPower) ;
            doubleJumpCounter = doubleJumpCounter -1;
            
        }

    }
    void OnCollisionEnter2D(Collision2D col)
    {
      if(col.gameObject.tag == "Ground")
      {

        
        doubleJumpCounter = 2;
        grounded = true;
        
      }   
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "PassLevel2")
        {
            SceneManager.LoadScene("Level2");

        }
        else if(other.gameObject.tag == "PassLevel3")
        {
            SceneManager.LoadScene("Level3");

        }
        else if(other.gameObject.tag == "KillZone")
        {
            SceneManager.LoadScene("DeathScene");

        }

        if(other.gameObject.tag == "PassFinalScene")
        {
            SceneManager.LoadScene("FinalScene");
        }
        if(other.gameObject.tag == "MobWeapon")
        {
            if(rb.velocity.x > 0)
            {
                rb.AddForce(Vector2.left * pushPower);
            }
            if(rb.velocity.x < 0)
            {
                rb.AddForce(Vector2.right * pushPower);
            }
            
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
