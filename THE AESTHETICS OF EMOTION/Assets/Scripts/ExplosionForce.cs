using UnityEngine;
using System.Collections;

public class ExplosionForce : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerStay (Collider other){
		if(Input.GetButtonDown("AButton") && other.gameObject.CompareTag("Bullet")){
			other.gameObject.SendMessage("Reverse");
		}

		if(Input.GetButtonDown("BButton") && other.gameObject.CompareTag("Bullet 2")){
			other.gameObject.SendMessage("Reverse");
		}

		if(Input.GetButtonDown("XButton") && other.gameObject.CompareTag("Bullet 3")){
			other.gameObject.SendMessage("Reverse");
		}

		if(Input.GetButtonDown("YButton") && other.gameObject.CompareTag("Bullet 4")){
			other.gameObject.SendMessage("Reverse");
		}

	}


}
