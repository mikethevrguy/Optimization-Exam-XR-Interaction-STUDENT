using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {

    [SerializeField]
     ParticleSystem pSystem;
    [SerializeField]
     GameManager scoreScript;

    void OnCollisionEnter(Collision col)
    {
        pSystem = col.GetContact(0).thisCollider.gameObject.GetComponentInChildren<ParticleSystem>();
        if (col.gameObject.CompareTag("Throwable"))
        {
            //Score Point
            scoreScript.UpdateScore();
            //Particle effect
            pSystem.Play();
        }

    }
}
