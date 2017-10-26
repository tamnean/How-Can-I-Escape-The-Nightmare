using UnityEngine;
using System.Collections;

public class YTransforms : MonoBehaviour {

	protected float deadEnd = 10f;
	protected float speedy;

	protected virtual void Start () {

	}
	

	protected virtual void Update () {
		SelfDestroy ();
		transform.Translate(-Time.deltaTime ,speedy*Time.deltaTime , 0);
	}

	protected virtual void SelfDestroy(){
		Vector3 position = transform.position;
		if (position.y > deadEnd) 
			Destroy(gameObject);
		if (position.x <= -10 || position.x >= 10)
			Destroy(gameObject);
	}
}


