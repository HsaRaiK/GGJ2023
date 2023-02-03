using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] GameObject kid;
    
    public static int health = 100;

    

    void OnColliderEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Bullet") || other.gameObject.CompareTag("MobWeapon"))
        {
            health = health - 5;

            
            
        }
    }

    void Update(){
        
        if(health <= 0)
            {
                SceneManager.LoadScene("DeathScene");

            }
    }
    

    
}
