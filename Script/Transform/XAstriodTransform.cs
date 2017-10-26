using UnityEngine;
using System.Collections;

public class XAstriodTransform : Transforms {


	protected override void Start () {
		speed = 4;
	}
	
	protected override void Update () {
		transform.Translate (-speed*Time.deltaTime ,-speed*Time.deltaTime , 0);
		base.Update ();

		Vector3 position = transform.position;
		if(position.y < -7) 
		   Destroy(gameObject);
	}

}
