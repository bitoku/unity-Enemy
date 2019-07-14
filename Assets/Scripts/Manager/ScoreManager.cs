using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int score1 = 0;
    int score2 = 0;
    GameObject score;

    void Start()
    {
        score = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ScoreUp1()
    {
        score1++;
    }

    public void ScoreUp2()
    {
        score2++;
    }
}
