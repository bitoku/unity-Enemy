using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusGeneratorBase : MonoBehaviour
{
    public GameObject virusPrefab;
    float span = 1.0f;
    float delta = 0;
    public float centerx;

    // Update is called once per frame
    void Update()
    {
        if (TimeManager.time > 30.0f)
        {
            return;
        }

        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject virus = Instantiate(virusPrefab) as GameObject;
            Debug.Log(virus.GetComponent<AudioSource>().clip);
            virus.transform.position = new Vector3(centerx, 6, 0);
            span *= 0.98f;
        }
    }
}
