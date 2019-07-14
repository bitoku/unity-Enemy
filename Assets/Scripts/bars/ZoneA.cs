﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneA : MonoBehaviour
{
    [SerializeField] GameObject LeftBar1;
    public Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = LeftBar1.GetComponent<Rigidbody2D>();
    }

    void OnMouseDrag()
    {
        rb2D.angularVelocity = 2880.0f;
    }
}
