using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private float DestroyTime;
    private float BallTimer;
    public GameObject ballPrefab;
    const float initialForce = 320.0f;
    public float centerx;
    bool alive = true;
    GameObject scoreDirector;

    private void Start()
    {
        scoreDirector = GameObject.Find("ScoreDirector");
    }
    // Update is called once per frame
    void Update()
    {
        if (TimeManager.time > 30.0f) return;

        if (!alive)
        {
            BallTimer += Time.deltaTime;
        }

        if (alive && transform.position.y < -6)
        {
            if (centerx < 0)
            {
                scoreDirector.GetComponent<ScoreDirector>().ScoreDown1();
            }
            else
            {
                scoreDirector.GetComponent<ScoreDirector>().ScoreDown2();
            }
            alive = false;
            BallTimer = 0f;
        }

        if(BallTimer > 2.0f && !alive)
        {
            alive = true;
            transform.position = new Vector3(centerx+1, -1, 0);
            Rigidbody2D rigid = GetComponent<Rigidbody2D>();
            rigid.velocity = new Vector3(0, 0, 0);
            BallTimer = 0f;
        }
    }
}
