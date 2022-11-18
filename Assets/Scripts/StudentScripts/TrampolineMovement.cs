using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineMovement : MonoBehaviour {

    public Vector3 direction = new Vector3(1,0,0);
    public float moveSpeed = 3.5f;
    public float moveTime = 3f;
    private float time;
    [SerializeField]
    Rigidbody rb;


	// Update is called once per frame
	void FixedUpdate () //will check every frame that we set on the propertie of the unity project in the "time" section
    {
        time += Time.deltaTime;
        //Debug.Log(time);
        if(time > moveTime)
        {
            time = 0;
            direction = direction * -1;
        }
        rb.MovePosition(transform.position + direction * Time.deltaTime* moveSpeed);
       // transform.position += direction * Time.deltaTime * moveSpeed;
        //Debug.Log(transform.position);
	}
}
