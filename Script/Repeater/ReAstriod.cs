using UnityEngine;
using System.Collections;

public class ReAstriod : Repeater {

	protected override void Start () {
		yMaxz = 7.5f;
		yMinz = 7.4f;
		xMax = 24;
		xMin = -4;
		startTime = 30;
		deleyMax = 12;
		deleyMin = 8;
		base.Start ();
	}
	

}
