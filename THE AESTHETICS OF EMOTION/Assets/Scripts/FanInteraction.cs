using UnityEngine;
using System.Collections;

public class FanInteraction : MonoBehaviour {

	Rigidbody body;


	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collision collision){
			body.AddForce( Vector3.up * Random.Range(100,150));

	}
}
