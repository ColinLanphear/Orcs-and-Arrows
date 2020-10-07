using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyManagerScript : MonoBehaviour
{

    public GameObject Archer;
    public GameObject Brute;

    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SendArcher", 1f, 2f);
        InvokeRepeating("SendBrute", 1f, 2f);
        
    }
    
    private void SendArcher()
    {
        GameObject instance = GameObject.Instantiate(Archer) as GameObject;
    }

    private void SendBrute()
    {
        GameObject instance = GameObject.Instantiate(Brute) as GameObject;
    }
}
