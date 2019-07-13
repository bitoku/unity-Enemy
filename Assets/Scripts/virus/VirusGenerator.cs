using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusGenerator : MonoBehaviour
{
    public GameObject virusPrefab;
    float span;
    float delta;

    // Start is called before the first frame update
    void Start()
    {
        span = 1.0f;
        delta = 0;
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject virus = Instantiate(virusPrefab) as GameObject;
            virus.transform.position = new Vector3(-3.333f, 6, 0);
        }
    }
}
