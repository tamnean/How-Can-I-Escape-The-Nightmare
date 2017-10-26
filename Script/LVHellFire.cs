using UnityEngine;
using System.Collections;

public class LVHellFire : MonoBehaviour {

	public GameObject lvPlus;
	void Start () {
		InvokeRepeating ("lv",60,60);
	}
	
	public void lv(){
		Instantiate (lvPlus,transform.position,Quaternion.identity);
	}
	
}
