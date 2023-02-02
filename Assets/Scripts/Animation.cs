using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    
    Rigidbody2D rb;
    Animator kidRun;
    Animator kidJump;
    Animator kidCrouch;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        kidRun = GetComponent<Animator>();
        kidJump = GetComponent<Animator>();
        kidCrouch = GetComponent<Animator>();

    }

    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)){
            kidRun.SetBool("Run" , true);
        }
        else
        {
            kidRun.SetBool("Run" , false);
        }
        if(rb.velocity.y > 0){
            kidJump.SetInteger("JumpOrFall" , 1);

        }
        else if(rb.velocity.y < 0 ){
            kidJump.SetInteger("JumpOrFall" , -1);
        }
        else{
            kidJump.SetInteger("JumpOrFall" , 0);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            kidCrouch.SetBool("Crouch" , true);

        }
        else{
            kidCrouch.SetBool("Crouch" , false);
        }
    }
}
