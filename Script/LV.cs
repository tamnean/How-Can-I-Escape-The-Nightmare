using UnityEngine;
using System.Collections;

public class LV : MonoBehaviour {

	public GameObject lvPlus;
	void Start () {
		InvokeRepeating ("lv",20,30);
	}

	public void lv(){
		Instantiate (lvPlus,transform.position,Quaternion.identity);
	}

}
