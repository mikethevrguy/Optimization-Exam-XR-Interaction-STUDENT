using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {

    ParticleSystem pSystem;
    GameManager scoreScript;

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () {
        scoreScript = GameObject.Find("GameManager").GetComponent<GameManager>();
        pSystem = GetComponentInChildren<ParticleSystem>();

	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Throwable")
        {
            //Score Point
            scoreScript.score++;
            //Particle effect
            pSystem.Play();

            Debug.Log("Trampoline Hit");
        }

    }
}
