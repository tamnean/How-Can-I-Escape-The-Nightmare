using UnityEngine;
using System.Collections;

public class BeamScript : MonoBehaviour {

	private SpriteRenderer spr;
	void Start () {
		spr = GetComponent<SpriteRenderer>();
		int i = Random.Range(1,3);
		if (i==1)
			spr.color = Color.cyan;
		else if(i==2)
			spr.color = Color.yellow;
		else if(i==3)
			spr.color = Color.white;
	}
	

	void Update () {
	}
		



	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == ("Wall")||other.gameObject.tag == ("Bat")||other.gameObject.tag == ("Astroid")||other.gameObject.tag == ("HellFire") ){
			Destroy (other.gameObject);
		}
	}
}
