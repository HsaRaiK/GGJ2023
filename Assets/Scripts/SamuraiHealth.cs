using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamuraiHealth : MonoBehaviour
{
    
    [SerializeField] GameObject Samurai;
    [SerializeField] GameObject Kid;
    public int health = 100;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            Samurai.SetActive(false);
            Kid.transform.position = Samurai.transform.position;
            Kid.SetActive(true);
            
        }
    }
}
