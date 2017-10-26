using UnityEngine;
using System.Collections;

public class Siren : MonoBehaviour {
	/*public GameObject siren;
	public GameObject Lv2;
	public UI SirenUi;
	public SpriteRenderer change;
	public Color colorW = Color.white;
	public Color colorB = Color.white;
	private int timeSiren;

	private void Start () {
		GetComponent<Siren>();
		GetComponent<UI> ();
	}
	

	private void Update () {
		Invoke("sirenCall",20);
		if (SirenUi.totalTime%90 ==89)
			Invoke ("CallLv2", 2);
	}

	private void sirenCall(){
		siren.SetActive (true);
		Invoke ("sirenOut",10);
		Invoke ("Whitey", 1);
	}

	private void sirenOut(){
		siren.SetActive (false);
		CancelInvoke ("sirenCall");

	}

	private void Whitey(){
		change.color = colorW;
		Invoke ("CancleWhite", 1);
	
	}

	private void CancleWhite(){
		change.color = colorB;
		CancelInvoke ("Whitey");
	}

	private void CallLv2(){
		Vector3 position = new Vector3(0,0,0);
		Instantiate(Lv2,position,Quaternion.identity);
		CancelInvoke ("CallLv2");
	}*/
	
}
