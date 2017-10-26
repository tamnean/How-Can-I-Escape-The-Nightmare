using UnityEngine;
using System.Collections;

public class ReHalo : Repeater {


	protected override  void Start () {
		yMaxz = 4.3f;
		yMinz = -4.3f;
		xMax = 10;
		xMin = 10;
		startTime = 1;
		deleyMax = 1;
		deleyMin = 1;
		base.Start ();
	}

}
