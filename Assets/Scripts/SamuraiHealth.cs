using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamuraiHealth : MonoBehaviour
{
    
    
    
    public int health = 100;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            PlayerSwitch.ninja.SetActive(false);
            PlayerSwitch.child.transform.position = PlayerSwitch.ninja.transform.position;
            PlayerSwitch.child.SetActive(true);
            
        }
    }
}
