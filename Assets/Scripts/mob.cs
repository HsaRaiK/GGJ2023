using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mob : MonoBehaviour
{
    public int hP = 1;
    private int currentHp;
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
         // animation ?
         
         Debug.Log("Died");
         Destroy(this.gameObject);
         
    }
}
