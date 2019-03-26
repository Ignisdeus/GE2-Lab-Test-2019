﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("KillMe", 10);
    }

    public void KillMe()
    {
        Destroy(this.gameObject);
    }

    void Update()
    {

        transform.Translate(Vector3.forward * speed * Time.deltaTime); 

    }

    
}
