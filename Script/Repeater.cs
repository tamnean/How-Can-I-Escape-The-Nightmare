using UnityEngine;
using System.Collections;

public class Repeater : MonoBehaviour {
	public Transform objecty;
	protected float yMaxz;
	protected float yMinz;
	protected float xMax = 15;
	protected float xMin = 10;
	protected float startTime;
	protected float deleyMax;
	protected float deleyMin;

	protected virtual void Start () {
		InvokeRepeating ("Repeat" , startTime , Random.Range(deleyMin,deleyMax));
	}
	

	protected virtual void Update () {

	}

	protected virtual void Repeat(){
		Vector3 position = objecty.position;
		
		position.y = Random.Range (yMaxz, yMinz);
		position.x = Random.Range (xMax,xMin);
		GameObject.Instantiate(objecty , position , Quaternion.identity);
	}
}