using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamuraiAnimation : MonoBehaviour
{
    Rigidbody2D rb;
    Animator SRun;
    Animator SJump;
    Animator SDash;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SRun = GetComponent<Animator>();
        SJump = GetComponent<Animator>();
        SDash = GetComponent<Animator>();
        

    }

    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)){
            SRun.SetBool("Run" , true);
        }
        else
        {
            SRun.SetBool("Run" , false);
        }
        if(rb.velocity.y > 0){
            SJump.SetInteger("JumpOrFall" , 1);

        }
        else if(rb.velocity.y < 0 ){
            SJump.SetInteger("JumpOrFall" , -1);
        }
        else{
            SJump.SetInteger("JumpOrFall" , 0);
        }
        if(Input.GetKey(KeyCode.LeftShift) & PlayerMovement.canDash == true){
            SDash.SetBool("Dash" , true);
        }
        else{
            SDash.SetBool("Dash" , false);
        }
        
    }
}
