using UnityEngine;
using System.Collections;

public class XLuminescenceTransform : Transforms {
	public GameObject HaloDis;

	protected override void Start () {
		speed = 2;
	}

	protected override void Update () {
		base.Update ();
	}

	private void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Player")){
			Object Clone = Instantiate(HaloDis, transform.position, Quaternion.identity);
			Destroy(Clone,0.6f);
			Destroy (gameObject);
			
		}
	}
}
