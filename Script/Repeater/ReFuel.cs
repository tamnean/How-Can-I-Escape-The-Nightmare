using UnityEngine;
using System.Collections;

public class ReFuel : Repeater {


	protected override void Start () {
		yMaxz = 4.3f;
		yMinz = -4.3f;
		startTime = 1;
		deleyMax = 20;
		deleyMin = 10;
		base.Start ();
	}
	

	protected override void Update () {
	
	}
}
