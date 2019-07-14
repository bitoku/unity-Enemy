using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VirusControllerBase : MonoBehaviour
{
    const float moveSpan = 0.5f;
    float delta = 0;
    bool isMoving = false;
    Vector3 beforePos;
    Vector3 directionPos;
    public float centerx;
	public GameObject manager;

    public void Start()
	{
		manager = GameObject.Find("ScoreDirector");
	}

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > moveSpan)
        {
            delta = 0;
            isMoving = !isMoving;
            beforePos = gameObject.transform.position;
            Vector3 nextPos = new Vector3(centerx + Random.Range(-1.8f, 1.8f), Random.Range(-0.5f, 2.5f), 0);
            directionPos = nextPos - beforePos;
        }

        if (isMoving)
        {
            float t = delta / moveSpan;
            float progress = t - Mathf.Sin(2 * Mathf.PI * t) / (2 * Mathf.PI);
            transform.position = directionPos * progress + beforePos;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (TimeManager.time > 30.0f)
        {
            return;
        }

        ScoreUp();
		Destroy(gameObject);
    }

	public abstract void ScoreUp();
}
