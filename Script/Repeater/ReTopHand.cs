using UnityEngine;
using System.Collections;

public class ReTopHand : Repeater {
	
	protected override void Start () {
		yMaxz =5.5f;
		yMinz =5.5f;
		xMax =20;
		xMin =10;
		startTime = 2;
		deleyMax = 15;
		deleyMin = 5;
		base.Start ();
	}
	
}
