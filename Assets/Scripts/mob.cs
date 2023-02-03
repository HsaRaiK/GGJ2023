using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mob : MonoBehaviour
{
    public int hP = 1;
    public static int currentHp;
    public static bool isDead = false;
    void Start()
    {
        currentHp = hP;
    }

    public void damage(int damage)
    {
        currentHp -= damage;

        if (currentHp <= 0)
        {
           
            Die();
        }

       
    }
    void Die()
    {
         
         isDead = true;
         Wait();
         Debug.Log("Died");
         Destroy(this.gameObject);
         
         
    }
    IEnumerator Wait(){
      yield return new WaitForSeconds(2);
    }
}
