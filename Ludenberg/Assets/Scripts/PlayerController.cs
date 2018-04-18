﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // MUST BE PUBLIC or else Unity cannot access variable.
    public float _speed = 3.0f;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") >= 0.5f || Input.GetAxisRaw("Horizontal") <= -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * _speed * Time.deltaTime, 0.0f, 0.0f));
        }

        if (Input.GetAxisRaw("Vertical") >= 0.5f || Input.GetAxisRaw("Vertical") <= -0.5f)
        {
            transform.Translate(new Vector3(0.0f, Input.GetAxisRaw("Vertical") * _speed * Time.deltaTime, 0.0f));
        }
    }
}
