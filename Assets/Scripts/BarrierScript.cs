using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierScript : MonoBehaviour
{
    public float health = 1f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
 

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            health -= 0.2f;
            Debug.Log("WallHit");

        }
        
        if (other.gameObject.tag == "enemyProjectile")
        {
            Destroy(other.gameObject);
            health -= 0.1f;
            Debug.Log("WallHitArrow");
        }
    }
}
