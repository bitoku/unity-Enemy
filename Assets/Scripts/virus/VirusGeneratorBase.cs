using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusGeneratorBase : MonoBehaviour
{
    public GameObject virusPrefab;
    const float span = 1.0f;
    float delta = 0;
    public float centerx;

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject virus = Instantiate(virusPrefab) as GameObject;
            virus.transform.position = new Vector3(centerx, 6, 0);
        }
    }
}
