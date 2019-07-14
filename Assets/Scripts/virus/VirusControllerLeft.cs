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
		manager.GetComponent<ScoreDirector>().ScoreUp1();
	}
}
