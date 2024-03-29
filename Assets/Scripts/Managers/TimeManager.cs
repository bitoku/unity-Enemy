﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public static float time;
    public Image UIobj;
    public Text timeText;
    bool finished;

    // Start is called before the first frame update
    void Start()
    {
        finished = false;
        time = 0f;
        UIobj.fillAmount = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        int RemainTime = 30 - Mathf.RoundToInt(time);

        if ( time <= 30f )
        {
            UIobj.fillAmount += Time.deltaTime / 30f ;
        }

        if( 0 <= RemainTime && time <= 30f )
        {
            timeText.text = RemainTime.ToString();
        }

        if (!finished && time > 30f)
        {
            finished = true;
            GetComponent<AudioSource>().Play();
        }

        if( time > 35f )
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
