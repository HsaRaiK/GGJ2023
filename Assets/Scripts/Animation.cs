using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    
    
    Animator kidRun;
    void Start()
    {
        kidRun = GetComponent<Animator>();

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
    }
}
