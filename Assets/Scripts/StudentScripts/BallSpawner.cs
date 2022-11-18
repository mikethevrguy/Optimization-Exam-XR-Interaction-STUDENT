using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{

    public GameObject pooledBall; //the prefab of the object in the object pool
    public static BallSpawner SharedInstance; // so we can reference this script without having to get the script component
    public List<GameObject> pooledObjects; // list of the object pool
    public int amountTolPool; // how many objects to instantiate

    private void Awake()
    {
        SharedInstance = this; // assigns this script to the SharedInstance variable
    }
    private void Start()
    {
        pooledObjects = new List<GameObject>(); //initialize the pooledObjects list with a new list
        GameObject tmpObject; // create a temp GameObject
        for (int i = 0; i < amountTolPool; i++)
        {

            tmpObject = Instantiate(pooledBall); // instantiate a copy of the pooledBall and assign to tmpObject
            tmpObject.SetActive(false); // set it to false (will activate as needed)
            pooledObjects.Add(tmpObject); // add the new Game Object to the pooledObjects list
        }
        // call the SpawnBall function every second
        InvokeRepeating("SpawnBall", 0f, 1f);
    }

    public GameObject GetPooledObject() // method will return a GameObject type
    {
        // loop through pooledObject list
        for (int i = 0; i < amountTolPool; i++)
        {
            if (!pooledObjects[i].activeInHierarchy) // if the current item in the list is not active
            {
                return pooledObjects[i]; // return the current object in the list
            }
        }
        return null; // if there are no inactive object return nothing
    }
    void SpawnBall()
    {
        GameObject ball = BallSpawner.SharedInstance.GetPooledObject(); // gets an inactive ball from the pool
        // if a ball is returned from the pool
        if (ball != null)
        {
            // sets the rotation and position of the ball from the pool to the spawn point
            ball.transform.position = gameObject.transform.position;
            ball.transform.rotation = gameObject.transform.rotation;
            // zeros out the velocity of the ball
            ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            // sets the ball as active
            ball.SetActive(true);
        }
    }
}