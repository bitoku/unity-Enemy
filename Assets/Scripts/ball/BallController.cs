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
    bool alive = true;

    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (!alive)
        {
            BallTimer += Time.deltaTime;
        }

        if (alive && transform.position.y < -6)
        {
            alive = false;
            BallTimer = 0f;
        }

        if(BallTimer > 2.0f && !alive)
        {
            alive = true;
            transform.position = new Vector3(centerx, -5, 0);
            Rigidbody2D rigid = GetComponent<Rigidbody2D>();
            rigid.velocity = new Vector3(0, 0, 0);
            Vector3 direction = new Vector3(Random.Range(-0.05f, 0.05f), 1, 0);
            rigid.AddForce(direction * initialForce);
            BallTimer = 0f;
        }
    }
}
