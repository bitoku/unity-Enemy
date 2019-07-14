using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private float DestroyTime;
    private float BallTimer;
    public GameObject ballPrefab;
    const float initialForce = 500.0f;
    public float centerx;

    private void Start()
    {
        BallTimer = 0f;
    }
    // Update is called once per frame
    void Update()
    {
        if ( gameObject.activeSelf)
        {
            BallTimer += Time.deltaTime;
        }
        else
        {

        }

        if (transform.position.y < -10)
        {
            gameObject.SetActive(false);
            enabled = false;
            DestroyTime = BallTimer;
            Debug.Log(BallTimer);
            enabled = true;
        }
        if(BallTimer > DestroyTime + 2.0f)
        {
            GameObject ball = Instantiate(ballPrefab) as GameObject;
            ball.transform.position = new Vector3(centerx, -6, 0);
            Rigidbody2D rigid = ball.GetComponent<Rigidbody2D>();
            Vector3 direction = new Vector3(Random.Range(-0.05f, 0.05f), 1, 0);
            rigid.AddForce(direction * initialForce);
            BallTimer = 0f;
        }
    }
}
