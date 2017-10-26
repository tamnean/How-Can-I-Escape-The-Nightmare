using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public GameObject HowtoBoard;
	public GameObject BackToMain;

	public void OnLoad(string name){
		Application.LoadLevel (name);
	}

	public void OnHowToClick(){
		HowtoBoard.SetActive(true);
	}
	public void Back(){
		HowtoBoard.SetActive(false);
	}
	public void OnExit(){
		Application.Quit ();
	}
}
