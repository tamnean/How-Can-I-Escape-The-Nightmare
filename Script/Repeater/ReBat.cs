using UnityEngine;
using System.Collections;

public class ReBat : Repeater {


	protected override void Start () {
		yMaxz = 4.3f;
		yMinz = -4.3f;
		startTime = 10;
		deleyMax = 10;
		deleyMin = 6;
		base.Start ();
	}
}
