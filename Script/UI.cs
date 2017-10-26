using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour 
{
	//canvas
	public int Hp = 100;
	public int totalKey;
	public int lumi = 100;
	private int totalTime;
	private int time1;
	private int time2;
	private int Best;
	public LampControl LC;
	public Player player;
	

	public Text HpText;
	public Slider HpSlider;
	public Text KeyText;
	public Text LumiText;
	public Text TimeText;
	public Text timePresentText;
	public Text timeBestText;
	public GameObject scoreBoard;
	public GameObject HeartDiePrefab;
	public Image halo;
	public Image hpFill;
	public GameObject beamPrefab;
	public Button BeamButton;
	public GameObject PAura;
	public Button PAuraButton;
	public Button HealHPButton;
	public Button HealLightButton;
	public Button ArrowButton;
	public GameObject ArrowPrefab;
	public Button ArrowSeal;
	public Button HealHPSeal;
	public Button HealLightSeal;
	public Button PAuraSeal;
	public Button BeamSeal;




	public void Start(){
		scoreBoard.SetActive (false);
		Time.timeScale = 1;
		totalKey = 15;
	}


	public void Update(){
		HpText.text = Hp.ToString();
		HpSlider.value = Hp;
		KeyText.text = totalKey.ToString ();
		TimeText.text = totalTime.ToString ();
		LumiText.text = lumi.ToString ();
		timeBestText.text = Best.ToString ();
		LC.lightAngle = lumi +20;

		Invoke("OnFuelDecrease",1);

		if (Hp <= 0||lumi<=0)
			Invoke ("showScore", 2);

		totalTime = (int)Time.timeSinceLevelLoad;

		if (lumi <= 20)
			halo.color = Color.red;
		else if(lumi <=40)
			halo.color = Color.yellow;
		else
			halo.color = Color.white;


		if (Hp <= 20)
			hpFill.color = Color.red;
		else if (Hp <= 40)
			hpFill.color = Color.yellow;
		else
			hpFill.color = Color.white;
	}
	
	public void OnIncrease(){
		Hp = Mathf.Clamp (Hp+30, 0, 100);
	}


	public void  OnFuelDecrease(){
		lumi = Mathf.Clamp (lumi - LC.burn, 0, 100);
		LC.lightAngle -= LC.burn;
		CancelInvoke ("OnFuelDecrease");
	}

	public void OnFuelIncrease(){
		lumi = Mathf.Clamp (lumi + 2, 0, 100);
		LC.lightAngle += 2;
	}

	public void OnKeyPlus(){
		totalKey += 1;
	}

	public void OnWall(){
		Hp = Mathf.Clamp (Hp-15, 0, 100);
	}

	public void OnBat(){
		Hp = Mathf.Clamp (Hp-5, 0, 100);
	}
	public void OnHellFire(){
		lumi = Mathf.Clamp (lumi-5, 0, 100);
	}
	public void OnAstroid(){
		Hp = Mathf.Clamp (Hp-10, 0, 100);
	}


	public void showScore(){
		scoreBoard.SetActive (true);
		time1 = totalTime;
		timePresentText.text = time1.ToString ();

		Best = PlayerPrefs.GetInt ("Best", 0);

		if (time1 > Best) {
			PlayerPrefs.SetInt ("Best", time1);
			timeBestText.text = Best.ToString ();
		}
		Time.timeScale = 0;
		CancelInvoke("showScore");
		
	}
	public void DestroyArrowSeal(){
		if(totalKey >=10){
			totalKey -=10;
			Destroy(ArrowSeal.gameObject);
		}
	}
	public void OnArrowButton(){
		if (lumi >20 ) {
			lumi -= 20;
			Instantiate (ArrowPrefab, player.transform.position, Quaternion.identity);
			Invoke("ArrowEnable",5);
			ArrowButton.interactable= false;
		}
	}
	void ArrowEnable(){
		ArrowButton.interactable= true;
	}

	public void DestroyHealHPSeal(){
		if(totalKey >=5){
			totalKey -=5;
			Destroy(HealHPSeal.gameObject);
		}
	}
	public void HealHp(){
		if (lumi>30){
			lumi -= 30;
			Object Clone = Instantiate(HeartDiePrefab, player.transform.position, Quaternion.identity);
			Destroy(Clone,1);
			Hp = Mathf.Clamp (Hp + 100, 0, 100);
			HealHPButton.interactable = false;
		}
		Invoke("HealHPEnableButton",30);
	}
	void HealHPEnableButton(){
		HealHPButton.interactable = true;
	}

	public void DestroyHealLightSeal(){
		if(totalKey >=5){
			totalKey -=5;
			Destroy(HealLightSeal.gameObject);
		}
	}
	public void HealLight(){
		if (Hp>30){
			Hp -= 30;
			Object Clone = Instantiate(HeartDiePrefab, player.transform.position, Quaternion.identity);
			Destroy(Clone,1);
			lumi = Mathf.Clamp (lumi + 100, 0, 100);
			HealLightButton.interactable = false;
		}
		Invoke("HealLightEnable",30);
	}
	void HealLightEnable(){
		HealLightButton.interactable = true;
	}

	public void DestroyPAuraSeal(){
		if(totalKey >=15){
			totalKey -=15;
			Destroy(PAuraSeal.gameObject);
		}
	}
	public void ShieldOn(){
		if (Hp>20) {
			Hp -= 20;
			PAura.SetActive (true);
			PAuraButton.interactable = false;
			Invoke ("ShieldOff", 10);
		}
	}
	void ShieldOff(){
		PAura.SetActive (false);
		Invoke("ShieldEnable",30);
	}
	void ShieldEnable(){
		PAuraButton.interactable = true;
	}
	//Beam
	public void DestroyBeamSeal(){
		if(totalKey >=20){
			totalKey -=20;
			Destroy(BeamSeal.gameObject);
		}
	}
	public void OnBeam(){
		if(lumi >20 && Hp>20){
			lumi -= 20;
			Hp -= 20;
			Object clone = Instantiate(beamPrefab, player.transform.position , Quaternion.identity);
			Destroy(clone,20);
			BeamButton.interactable = false;
			Invoke("BeamEnableButton",60);
		}
	}
	void BeamEnableButton(){
		BeamButton.interactable = true;
	}




	public void OnPlayAgian(string name){
		Application.LoadLevel (name);
	}

}
