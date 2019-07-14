using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreDirector : MonoBehaviour
{
    GameObject score1UI;
    GameObject score2UI;

    public Text Winer1;
    public Text Winer2;

    void Start()
    {
        score1UI = GameObject.Find("Score1");
        score2UI = GameObject.Find("Score2");

        score1UI.GetComponent<Text>().text = ScoreManager.score1.ToString();
        score2UI.GetComponent<Text>().text = ScoreManager.score2.ToString();

        if(ScoreManager.score1 > ScoreManager.score2)
        {
            Winer1.text = "WINER!!";
            Winer2.text = "";
        }
        if (ScoreManager.score1 < ScoreManager.score2)
        {
            Winer1.text = "";
            Winer2.text = "WINER!!";
        }
        if (ScoreManager.score1 == ScoreManager.score2)
        {
            Winer1.text = "DRAW";
            Winer2.text = "DRAW";
        }
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

    public void OnClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}
