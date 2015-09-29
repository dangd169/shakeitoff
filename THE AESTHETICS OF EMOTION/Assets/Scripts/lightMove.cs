using UnityEngine;
using System.Collections;

public class lightMove : MonoBehaviour {
	
	float targetZ;
	float targetNZ;
	public Transform targetRot;
	//public Transform targetNRot;
	float speed = 10;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Switch", 0f, 2f);

	}
	
	// Update is called once per frame
	void Update () {

		float rate = speed * Time.deltaTime;

		transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRot.rotation , rate);




	
	}


	void Switch () {
		speed = speed *-1;
	}
}
