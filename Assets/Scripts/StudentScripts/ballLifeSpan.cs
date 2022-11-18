using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballLifeSpan : MonoBehaviour
{
    public float lifeSpan = 10;
    private float lifeTimer;
    private void OnEnable()
    {
        lifeTimer = lifeSpan;
    }
    // Update is called once per frame
    void Update()
    {
        if (lifeTimer > 0)
        {
            lifeTimer -= Time.deltaTime;
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
