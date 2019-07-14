using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusControllerRight : VirusControllerBase
{
    void Start()
    {
        base.Start();
        centerx = 3.333f;
    }

    public override void ScoreUp()
	{
		manager.GetComponent<ScoreManager>().ScoreUp2();
	}
}
