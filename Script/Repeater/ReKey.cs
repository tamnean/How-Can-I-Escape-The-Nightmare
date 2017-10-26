using UnityEngine;
using System.Collections;

public class ReKey : Repeater {

	protected override void Start () {
		yMaxz = 9f;
		yMinz = 9f;
		xMax = 6;
		xMin = 0;
		startTime = 1;
		deleyMax = 20;
		deleyMin = 20;
		base.Start ();
	}
}
