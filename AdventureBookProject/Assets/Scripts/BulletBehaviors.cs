using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviors : MonoBehaviour
{

    public float OnscreenDelay = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject,OnscreenDelay);
    }

   
   
}
