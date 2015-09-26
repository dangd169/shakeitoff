using UnityEngine;
using System.Collections;

public class FlashSize : MonoBehaviour {

	LensFlare Swift;
	float timer;
	float pulse;




	// Use this for initialization
	void Start () {
		Swift = gameObject.GetComponent<LensFlare>();
		InvokeRepeating ("flashing",0,.075f);
	
	}

	void Update () {
		//Swift.brightness = Random.Range(1,5) * Time.deltaTime;
	}

	void flashing (){
		Swift.brightness = Random.Range (.15f,.5f);
	}


	

		
}
