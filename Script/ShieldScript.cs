using UnityEngine;
using System.Collections;

public class ShieldScript : MonoBehaviour {
	public GameObject player;
	public GameObject heartDie;


	void Awake(){
		gameObject.transform.position = player.transform.position;
	}

	void Update (){
		gameObject.transform.position = player.transform.position;
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Wall" || other.gameObject.tag == "Bat" || other.gameObject.tag == "Astroid" || other.gameObject.tag == "HellFire") {
			Object clone =Instantiate(heartDie,other.transform.position, Quaternion.identity);
			Destroy(other.gameObject);
			Destroy(clone,1);
		}
	}
}
