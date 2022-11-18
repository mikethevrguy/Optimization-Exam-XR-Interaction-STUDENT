using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballLifespan : MonoBehaviour
{
    [SerializeField]
    float lifeSpan = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("HideBall", lifeSpan);
    }

   private void Hideball()
    {
        gameObject.SetActive(false);
    }
}
