using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreDirector : MonoBehaviour
{
    GameObject score1UI;
    GameObject score2UI;

    public Text Winner1;
    public Text Winner2;

    void Start()
    {
        score1UI = GameObject.Find("Score1");
        score2UI = GameObject.Find("Score2");

        score1UI.GetComponent<Text>().text = ScoreManager.score1.ToString();
        score2UI.GetComponent<Text>().text = ScoreManager.score2.ToString();

        if (SceneManager.GetActiveScene().name == "StartScene")
        {
            if (ScoreManager.score1 > ScoreManager.score2)
            {
                Winner1.text = "WINNER!!";
                Winner2.text = "";
            }
            else if (ScoreManager.score1 < ScoreManager.score2)
            {
                Winner1.text = "";
                Winner2.text = "WINNER!!";
            }
            else
            {
                Winner1.text = "DRAW";
                Winner2.text = "DRAW";
            }
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

    public void ScoreDown1()
    {
        ScoreManager.score1 -= 10;
        score1UI.GetComponent<Text>().text = ScoreManager.score1.ToString();
    }

    public void ScoreDown2()
    {
        ScoreManager.score2 -= 10;
        score2UI.GetComponent<Text>().text = ScoreManager.score2.ToString();
    }

    public void OnClick()
    {
        ScoreManager.score1 = 0;
        ScoreManager.score2 = 0;
        SceneManager.LoadScene("GameScene");
    }
}
