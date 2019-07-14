using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDirector : MonoBehaviour
{
    GameObject score1UI;
    GameObject score2UI;

    void Start()
    {
        score1UI = GameObject.Find("Score1");
        score2UI = GameObject.Find("Score2");
        score1UI.GetComponent<Text>().text = ScoreManager.score1.ToString();
        score2UI.GetComponent<Text>().text = ScoreManager.score2.ToString();
    }

    public void ScoreUp1()
    {
        ScoreManager.score1 += 100;
        score1UI.GetComponent<Text>().text = ScoreManager.score1.ToString();
    }

    public void ScoreUp2()
    {
        ScoreManager.score2 += 100;
        score2UI.GetComponent<Text>().text = ScoreManager.score2.ToString();
    }
}
