using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMOB : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public static bool isMoving = false;

    private Transform target1;
    private Transform target2;
    


    void Start(){
        target1 = GameObject.FindGameObjectWithTag("MobFollow").GetComponent<Transform>();
        target2= GameObject.FindGameObjectWithTag("Kid").GetComponent<Transform>();
    }
    void Update(){
        
        if(PlayerSwitch.child.activeSelf == true)
        {
            FollowKid();
        }
        if(PlayerSwitch.child.activeSelf == false)
        {
            FollowNinja();
        }
        
        
    }


    void FollowNinja(){
        if(Vector2.Distance(transform.position,target1.position) < stoppingDistance){
            transform.position = Vector2.MoveTowards(transform.position,target1.position, speed*Time.deltaTime);
            isMoving = true;
        }
    }
    void FollowKid(){
        if(Vector2.Distance(transform.position,target2.position) < stoppingDistance){
            transform.position = Vector2.MoveTowards(transform.position,target2.position, speed*Time.deltaTime);
            isMoving = true;
        }
    }

    
    

}
