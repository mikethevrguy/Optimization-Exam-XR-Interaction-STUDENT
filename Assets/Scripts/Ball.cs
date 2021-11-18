using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool doDestroy = false;
    public bool doHide = false;
    public float lifeSpan = 10;
    private float lifeTimer;
    private void OnEnable()
    {
        lifeTimer = lifeSpan;
    }
    // Update is called once per frame
    void Update()
    {
        if (doHide)
        {
            if (lifeTimer > 0)
            {
                lifeTimer -= Time.deltaTime;
            }
            else
            {
                gameObject.SetActive(false);
            }
        } else if (doDestroy)
        {
            if (lifeTimer > 0)
            {
                lifeTimer -= Time.deltaTime;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        
    }

}
