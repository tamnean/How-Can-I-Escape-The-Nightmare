using UnityEngine;
using System.Collections;

public class SelfDestroy : MonoBehaviour {


	void Start () {

	}

	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Player")) 
			Destroy (gameObject);
	}
}
