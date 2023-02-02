using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamuraiAnimation : MonoBehaviour
{
    Rigidbody2D rb;
    Animator SRun;
    Animator SJump;
    Animator SDash;
    Animator SAttack;
    public Transform attckpoint;
    public float attckrange = 0.5f;
    public LayerMask Mobs;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SRun = GetComponent<Animator>();
        SJump = GetComponent<Animator>();
        SDash = GetComponent<Animator>();
        SJump = GetComponent<Animator>();
        SAttack = GetComponent<Animator>();
        

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

        if(rb.velocity.y > 0){
            SJump.SetInteger("JumpOrFall" , 1);

        }
        else if(rb.velocity.y < 0 ){
            SJump.SetInteger("JumpOrFall" , -1);
        }
        else{
            SJump.SetInteger("JumpOrFall" , 0);
        }

        if(Input.GetKeyDown(KeyCode.X)){
            SAttack.SetBool("Attack" , true);

            Collider2D[] getHit =Physics2D.OverlapCircleAll(attckpoint.position,attckrange, Mobs);

            foreach (Collider2D enemy in getHit)
            {
               Debug.Log("Ouch");
               
               enemy.GetComponent<mob>().damage(1);
            }
            
            
        }
        else{
            SAttack.SetBool("Attack" , false);
        }
        
        
    }

    private void OnDrawGizmosSelected()
    {
        if (attckpoint == null)
            return;
        
        Gizmos.DrawWireSphere(attckpoint.position,attckrange);
    }
}
