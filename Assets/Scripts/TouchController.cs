﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    Rigidbody2D rigidLeft1;
    Rigidbody2D rigidRight1;
    Rigidbody2D rigidLeft2;
    Rigidbody2D rigidRight2;

    private void Start()
    {
        GameObject barLeft1 = GameObject.Find("LeftBar1");
        GameObject barRight1 = GameObject.Find("RightBar1");
        GameObject barLeft2 = GameObject.Find("LeftBar2");
        GameObject barRight2 = GameObject.Find("RightBar2");
        rigidLeft1 = barLeft1.GetComponent<Rigidbody2D>();
        rigidRight1 = barRight1.GetComponent<Rigidbody2D>();
        rigidLeft2 = barLeft2.GetComponent<Rigidbody2D>();
        rigidRight2 = barRight2.GetComponent<Rigidbody2D>();

    }
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.touches[i];
            if (0 <= touch.position.x && touch.position.x < Screen.width/4)
            {
                rigidLeft1.angularVelocity = 4000.0f;
            }
            else if (Screen.width/4 <= touch.position.x && touch.position.x < Screen.width*2/4)
            {
                rigidRight1.angularVelocity = -4000.0f;
            }
            else if (Screen.width*2/4 <= touch.position.x && touch.position.x < Screen.width*3/4)
            {
                rigidLeft2.angularVelocity = 4000.0f;
            }
            else
            {
                rigidRight2.angularVelocity = -4000.0f;
            }
        }
    }
}
