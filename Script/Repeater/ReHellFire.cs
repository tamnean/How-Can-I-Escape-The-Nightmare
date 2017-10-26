using UnityEngine;
using System.Collections;

public class ReHellFire : Repeater {


	protected override void Start () {
		yMaxz = -8f;
		yMinz = -8f;
		xMax = 8;
		xMin = -8;
		startTime = 20;
		deleyMax = 8;
		deleyMin = 3;
		base.Start ();
	}
}
