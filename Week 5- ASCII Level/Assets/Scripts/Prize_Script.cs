﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prize_Script : MonoBehaviour
{
    public GameObject Ply;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject); //Destroy gameobject on collision
    }
}
