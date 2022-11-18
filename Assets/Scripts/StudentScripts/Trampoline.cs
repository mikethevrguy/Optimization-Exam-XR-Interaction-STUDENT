using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {

    public ParticleSystem pSystem;
    public GameManager scoreScript;


	// Update is called once per frame
	void Update () {
        scoreScript = GameObject.Find("GameManager").GetComponent<GameManager>();
        pSystem = GetComponentInChildren<ParticleSystem>();

	}

    void OnCollisionEnter(Collision col)
    {
        pSystem = col.GetContact(0).thisCollider.gameObject.GetComponent<ParticleSystem>();

        if (col.gameObject.CompareTag("Throwable"))
        {
            //Score Point
            scoreScript.UpdateScore();
            //Particle effect
            pSystem.Play();
        }

    }
}
