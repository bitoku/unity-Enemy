using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject ballPrefab;
    float span;
    float delta;
    float initialForce;

    // Start is called before the first frame update
    void Start()
    {
        span = 1.0f;
        delta = 0;
        initialForce = 700.0f;
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject ball = Instantiate(ballPrefab) as GameObject;
            ball.transform.position = new Vector3(-3.333f, -6, 0);
            Rigidbody2D rigid = ball.GetComponent<Rigidbody2D>();
            Vector3 direction = new Vector3(Random.Range(-0.05f, 0.05f), 1, 0);
            rigid.AddForce(direction * initialForce);
        }
        
    }
}
