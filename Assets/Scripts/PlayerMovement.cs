using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    
    [SerializeField] float horizontalSpeed = 5f;
    [SerializeField] float jumpPower = 5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }


    private void Update()
    {
        CharacterMovement();
        
            
        
    }



    private void CharacterMovement()
    {
        var movement = Input.GetAxis("Horizontal");
      
        transform.position += new Vector3(movement , 0 , 0) * horizontalSpeed/1000;

        if(Input.GetKeyDown(KeyCode.Space) == true){

            rb.velocity = new Vector2(movement , jumpPower);
        }



        
        
    }
}
