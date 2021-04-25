﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlledVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3_forceVelocity;

    [SerializeField]
    KeyCode keyPositive;

    [SerializeField]
    KeyCode keyNegative;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(keyPositive))
            GetComponent<Rigidbody>().velocity += v3_forceVelocity;

        if (Input.GetKey(keyNegative))
            GetComponent<Rigidbody>().velocity -= v3_forceVelocity;

    }
}
