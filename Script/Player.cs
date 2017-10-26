using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private Rigidbody rigid;
	private Collider playColl;
	public UI ui;
	private float speed;
	private float xMax= 8.5f,xMin = -8.5f,yMax=4.3f,yMin=-4.3f;
	public GameObject diePortal;
	public GameObject bb1;
	public GameObject shield;
	public AudioSource AuSource;

	public AudioClip AuOnWall;
	public AudioClip AuFuel;
	public AudioClip AuPlayerDie;
	public AudioClip AuThunderDie;
	
	float moveX ;
	float moveY;


	void Start () {
		playColl = GetComponent<Collider>();
		rigid = GetComponent<Rigidbody> ();
		GetComponent<UI> ();
		speed = 4;
		GetComponents<AudioSource> ();

	}


	void Update () {
		move ();
		if (ui.Hp <= 0 || ui.lumi<=0) {
			speed=0;
			Invoke("OnDie",0);
		}
	} 

	void move(){
		moveX = Input.GetAxis ("Horizontal");
		moveY = Input.GetAxis ("Vertical");
		Vector3 move = new Vector3 (moveX, moveY, 0);
		rigid.velocity = move * speed  ;
		rigid.position = new Vector3 (
			Mathf.Clamp(rigid.position.x, xMin ,xMax) ,
			Mathf.Clamp(rigid.position.y, yMin , yMax),0.0f);
	}
	
	void OnTriggerEnter (Collider other){
		if (other.CompareTag ("Heart")) {
			ui.OnIncrease ();
			AuSource.PlayOneShot(AuFuel);
		}
		if (other.CompareTag ("Lumi"))
			ui.OnFuelIncrease ();
		if (other.gameObject.tag == "Key") {
			ui.OnKeyPlus ();
			Destroy(other.gameObject);
			AuSource.PlayOneShot(AuFuel);
		}
		if (other.gameObject.tag == "Wall") {
			ui.OnWall ();
			OnTouchObtacle();
			ObtacleDieEffect(other.gameObject);
		}
		if (other.gameObject.tag == "Bat") {
			ui.OnBat ();
			ObtacleDieEffect(other.gameObject);
			OnTouchObtacle();
		}
		if (other.gameObject.tag == "Astroid") {
			ui.OnAstroid ();
			ObtacleDieEffect(other.gameObject);
			OnTouchObtacle();
		}
		if (other.gameObject.tag == "HellFire") {
			ui.OnHellFire ();
			ObtacleDieEffect(other.gameObject);
			OnTouchObtacle();
		}
	}

	void OnDie(){
		ui.Hp = 0;
		ui.lumi = 0;
		playColl.enabled = false;
		AuSource.PlayOneShot (AuPlayerDie);
		AuSource.PlayOneShot (AuThunderDie);
		Object clone =  Instantiate (diePortal, transform.position, Quaternion.identity);
		Destroy (clone,5);
		Destroy (gameObject);
		CancelInvoke("OnDie");
	}

	void ObtacleDieEffect(GameObject other){
		AuSource.PlayOneShot (AuOnWall);
		Object clone1 = Instantiate(bb1, transform.position, Quaternion.identity);
		Destroy (clone1, 1);
		Destroy (other.gameObject);
		if (moveX !=0|| moveY!=0) 
			rigid.AddForce(4000*new Vector3(-moveX,-moveY,0));
		else
			rigid.AddForce(4000*new Vector3(-1,Random.Range(-1,1),0));
	}
	void OnTouchObtacle(){
		if (ui.Hp > 0 || ui.lumi>0) {
			shield.SetActive(true);
			Invoke("shieldOff",1);
		}
	}
	void shieldOff(){
		shield.SetActive(false);
	}


}
