using UnityEngine;
using System.Collections;

public class ArrowScript : MonoBehaviour {
	private float deadEnd;
	private int speed;
	private Rigidbody RigidArr;
	public GameObject wallDie;

	private void Start () {
		speed = 3;
		RigidArr = GetComponent<Rigidbody>();
	}

	private void Update () {
		Vector3 move = new Vector3 (1,0,0);
		RigidArr.velocity = move * speed  ;
		if (gameObject.transform.position.x > 10)
			Destroy (gameObject);
	}

	private void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == ("Wall")||other.gameObject.tag == ("Bat")||other.gameObject.tag == ("Astroid")||other.gameObject.tag == ("HellFire") ){
			Destroy (other.gameObject);
			Object WallClone = Instantiate(wallDie,other.transform.position,Quaternion.identity);
			Destroy(WallClone,1);
		}
	}
}
