using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMovement : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] GameObject mob;
    [SerializeField] GameObject players;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(mob.transform.position.x - GameObject.FindGameObjectWithTag("MobFollow").transform.position.x > 0)
        {
            mob.transform.rotation = Quaternion.Euler(0, 180, 0);
            

        }
        if(mob.transform.position.x - GameObject.FindGameObjectWithTag("MobFollow").transform.position.x < 0){
            mob.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        
    }
}

