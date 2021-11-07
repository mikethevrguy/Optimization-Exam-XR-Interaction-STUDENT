using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    

    public GameObject ballPrefab; 

    private void Awake()
    {
        
    }
    private void Start()
    {
        InvokeRepeating("SpawnBall", 0f, 0.5f);
    }
    
   	
	// Update is called once per frame
	private void Update () 
    {
	
	}

    void SpawnBall()
    {
        Instantiate(ballPrefab);
        Debug.Log("ball spawned");
    }
}
