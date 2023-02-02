using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamuraiAttack : MonoBehaviour
{
   [SerializeField] GameObject samuraiHit;
   public Transform gameobject;

   
   


   void Update()
   {
    if(Input.GetKeyDown(KeyCode.X))
    {
        Attack();
        

    }
   }

   void Attack()
   {
    
    Instantiate(gameObject , gameobject.position , Quaternion.identity);
    
   }
}
