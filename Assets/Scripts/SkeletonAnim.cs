using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonAnim : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] GameObject skeleton;
    Animator SkRun;
    Animator SkDead;
    
    
    Animator SAttack;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SkRun = GetComponent<Animator>();
        SkDead = GetComponent<Animator>();        
        
        

    }

    void Update()
    {
        if(AIMOB.isMoving == true)
        {
            SkRun.SetBool("Run" , true);
        }
        else
        {
            SkRun.SetBool("Run" , false);
        }
        if(mob.isDead == true & mob.currentHp > 0)
        {
            SkDead.SetBool("Dead" , true);
            
        }
        else
        {
            SkDead.SetBool("Dead" ,false);
        }
        
        

       
}
}

