using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamuraiAttack : MonoBehaviour
{
   [SerializeField] GameObject gameObject;
   public Transform gameobject;
   


   void Update()
   {
    if(Input.GetKeyDown(KeyCode.X))
    {
        

    }
   }

   void Attack()
   {
    
    Instantiate(gameObject , gameobject.position , Quaternion.identity);
    
   }
}
