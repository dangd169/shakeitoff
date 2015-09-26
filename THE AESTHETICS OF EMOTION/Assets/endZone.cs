using UnityEngine;
using System.Collections;

public class endZone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other){

		if(other.tag == "Taxi"){
			other.SendMessageUpwards ("ReverseCar");

		}

		if(other.tag == "Stranger"){
			other.SendMessageUpwards ("ReversePerson");
		}

	}
}
