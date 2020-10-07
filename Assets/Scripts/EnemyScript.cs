using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyScript : MonoBehaviour
{

    public GameObject enemyProjectile;

    public float xPos, yPos, ySpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        xPos = Random.Range(-6.5f, 6.5f);
        yPos = 8f;
        ySpeed = -0.01f;
        
        
        //shooting
        float delay = Random.Range(2f, 5f);
        float rate = Random.Range(2f, 5f);
        
        InvokeRepeating("Fire", delay, rate);
    }

    // Update is called once per frame
    private void Update()
    {
        yPos += ySpeed;
        transform.position = new Vector2(xPos, yPos);

        if (yPos <= 3f)
        {
            ySpeed = 0;
        }
        
        
    }

    private void Fire()
    {
        int i = Random.Range(0, 100);
        
        if (i > 1)
        {
            Instantiate(enemyProjectile, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
        }
    }
}
