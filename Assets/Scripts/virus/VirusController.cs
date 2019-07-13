using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusController : MonoBehaviour
{
    float moveSpan = 0.5f;
    float delta;
    bool isMoving;
    Vector3 beforePos;
    Vector3 nextPos;
    Vector3 directionPos;

    // Start is called before the first frame update
    void Start()
    {
        delta = 0;
        isMoving = false;
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > this.moveSpan)
        {
            delta = 0;
            isMoving = !isMoving;
            beforePos = gameObject.transform.position;
            nextPos = new Vector3(Random.Range(-5, -2), Random.Range(1, 4), 0);
            directionPos = nextPos - beforePos;
        }

        if (isMoving)
        {
            float t = delta / moveSpan;
            float progress = t - Mathf.Sin(2 * Mathf.PI * t) / (2 * Mathf.PI);
            Vector3 stepPos = directionPos * progress + beforePos;
            transform.position = stepPos;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
