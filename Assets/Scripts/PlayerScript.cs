using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class PlayerScript : MonoBehaviour {
    private float     xPos;
    public float      speed = .05f;
    public float      leftWall, rightWall;

    public float health = 0.2f;

    public GameObject projectile;
    public KeyCode fireKey;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow)) {
            if (xPos > leftWall) {
                xPos -= speed;
            }
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            if (xPos < rightWall) {
                xPos += speed;
            }
        }

        if (Input.GetKeyUp(fireKey))
        {
            Instantiate(projectile, new Vector2(transform.position.x, transform.position.y + 0.5f), Quaternion.identity);
        }
        transform.localPosition = new Vector3(xPos, transform.position.y, 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            health -= 0.2f;
            Debug.Log(health);

        }
        
        if (other.gameObject.tag == "enemyProjectile")
        {
            Destroy(other.gameObject);
            health -= 0.1f;
            Debug.Log(health);
        }
    }
}


