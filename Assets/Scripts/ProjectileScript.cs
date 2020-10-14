using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectileScript : MonoBehaviour
{
    public float               speed = 2f;
    public int direction;
    private Rigidbody2D        rb;


    
    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine("Launch");
    }

    void Update()
    {

    }
    
    private IEnumerator Launch() {
        
        rb.AddForce(transform.up * speed * direction);
        yield return null;
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            //award
            ScoreScript.ArcherValue ++; 
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "wall")
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player Damaged");
            

        }
        if (other.gameObject.tag == "enemyProjectile")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
