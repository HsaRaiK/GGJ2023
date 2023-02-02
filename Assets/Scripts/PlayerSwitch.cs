using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    [SerializeField]   GameObject child;
    [SerializeField]   GameObject ninja;

    [SerializeField] float switchTime = 6f;

    [SerializeField] float switchCoolDown = 5f;
    private bool runSwitch = true;
    void Start()
    {
        ninja.SetActive(false);
        runSwitch = true;
    }

    
    void Update()
    {
        
        if(Input.GetKey(KeyCode.R) & runSwitch == true)
        {
            StartCoroutine(BackSwitch());
            PlayerMovement.canDash = true;
        }
    }

    void ChildToNinja(){
        ninja.transform.position = child.transform.position;
        child.SetActive(false);
        ninja.SetActive(true);

    }
    void NinjaToChild()
    {
        child.transform.position = ninja.transform.position;
        child.SetActive(true);
        ninja.SetActive(false);

    }
    IEnumerator BackSwitch(){
        runSwitch = false;
        ChildToNinja();
        yield return new WaitForSeconds(switchTime);
        NinjaToChild();
        yield return new WaitForSeconds(switchCoolDown);
        runSwitch = true;

        


    }
}
