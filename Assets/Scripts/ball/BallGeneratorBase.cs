using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGeneratorBase : MonoBehaviour
{
    public GameObject ballPrefab;
    const float span = 1.0f;
    const float initialForce = 400.0f;
    float delta = 0;
    public float centerx;

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject ball = Instantiate(ballPrefab) as GameObject;
            ball.transform.position = new Vector3(centerx, -6, 0);
            Rigidbody2D rigid = ball.GetComponent<Rigidbody2D>();
            Vector3 direction = new Vector3(Random.Range(-0.05f, 0.05f), 1, 0);
            rigid.AddForce(direction * initialForce);
        }

    }
}
