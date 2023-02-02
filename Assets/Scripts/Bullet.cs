using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject player;
    public float force = 5;
    private Rigidbody2D rb;

    [SerializeField] GameObject bulletClone;
    Vector3 direction;

     void Start()
     {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("BulletTarget");
        direction = player.transform.position - transform.position;
        rb.velocity = new Vector2(direction.x , direction.y).normalized * force;
    }


    
}
