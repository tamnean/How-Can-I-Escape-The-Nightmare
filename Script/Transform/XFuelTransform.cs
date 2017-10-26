using UnityEngine;
using System.Collections;

public class XFuelTransform : Transforms {
	public GameObject HeartDie;

	protected override void Start () {
		speed = 2;
	}
	

	protected override void Update () {
		base.Update ();
	}

	private void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Player")){
			Object Clone = Instantiate(HeartDie, transform.position, Quaternion.identity);
			Destroy(Clone,1);
			Destroy (gameObject);
		}
	}
}
