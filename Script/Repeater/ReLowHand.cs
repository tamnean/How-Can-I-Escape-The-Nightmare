using UnityEngine;
using System.Collections;

public class ReLowHand : Repeater {


	protected override void Start () {
		yMaxz = -4.5f;
		yMinz = -4.5f;
		xMax =20;
		xMin =10;
		startTime = 1;
		deleyMax = 15;
		deleyMin = 5;
		base.Start ();
	}
}
