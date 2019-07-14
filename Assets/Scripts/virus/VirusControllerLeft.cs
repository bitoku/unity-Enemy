using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusControllerLeft : VirusControllerBase
{
    new void Start()
    {
		base.Start();
        centerx = -3.333f;
    }

    public override void ScoreUp()
	{
        Debug.Log("prefab");
        Debug.Log(GetComponent<AudioSource>().clip);
        GetComponent<AudioSource>().Play();
        manager.GetComponent<ScoreDirector>().ScoreUp1();
	}
}
