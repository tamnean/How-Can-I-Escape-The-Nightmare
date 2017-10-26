using UnityEngine;
using System.Collections;

public class LampControl : MonoBehaviour {
	public float ltLevel;
	public Light lt;
	public int burn;
	public UI lumiOnLamp;
	public float lightAngle;

	//Spot-light
	void Start () {
		lt = GetComponent<Light>();
		lt.range = 13f;
		lt.spotAngle = lightAngle + 10;

	}

	void Update () {
		if (lumiOnLamp.lumi >= 70) {
			ltLevel = 3;
			burn = 1;
		} else if (lumiOnLamp.lumi >= 40 && lumiOnLamp.lumi < 70) {
			ltLevel = 2;
			burn = 1;
		} else {
			ltLevel = 1;
			burn = 1;
		}
		lt.spotAngle = lightAngle ;
	}
}
