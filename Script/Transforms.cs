using UnityEngine;
using System.Collections;

public class Transforms : MonoBehaviour {
	protected float deadEnd = -10f;
	protected float speed;

	protected virtual void Start () {

	}

	protected virtual void Update () {
		SelfDestroy ();
		transform.Translate (-speed*Time.deltaTime ,0 , 0);

	}

	protected virtual void SelfDestroy(){
		Vector3 position = transform.position;
		if (position.x < deadEnd) 
			Destroy(gameObject);
		if (position.y <= -7.5 || position.y >= 7.5)
			Destroy(gameObject);
	}
}
