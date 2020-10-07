using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class BruteScript : MonoBehaviour
{

    public float xPos, yPos, ySpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        xPos = Random.Range(-6.5f, 6.5f);
        yPos = 8f;
        ySpeed = -0.025f;
    }

    // Update is called once per frame
    private void Update()
    {
        yPos += ySpeed;
        transform.position = new Vector2(xPos, yPos);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "wall")
        {
            Destroy(this.gameObject);
        }
    }
}
