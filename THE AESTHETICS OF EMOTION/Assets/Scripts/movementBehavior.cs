using UnityEngine;
using System.Collections;

public class movementBehavior : MonoBehaviour {
	
	float strangerSpeed;
	float taxiSpeed;
	float taxiPosition;

	void Start () {

		taxiSpeed = Random.Range (3,5);
		strangerSpeed = Random.Range (1,3);
	
		
	}
	void Update () {

		if(this.tag == "Stranger"){
			transform.Translate(Vector3.left * Time.deltaTime * strangerSpeed);
		}

		if(this.tag == "StrangerLeft"){
			transform.Translate(Vector3.left * Time.deltaTime * strangerSpeed);
		}
		
		if(this.tag == "Taxi"){
			transform.Translate(Vector3.left * Time.deltaTime * taxiSpeed);
			taxiPosition = transform.position.z;
		}
	}
	void ReverseCar () {
		if(taxiPosition == 25){
			transform.Translate (new Vector3(0, 0, -14), Space.World);
		}
		if(taxiPosition == 11){
			transform.Translate (new Vector3(0, 0, 14), Space.World);
		}
		taxiSpeed = Random.Range (4,5);
		transform.Rotate(0,180,0);
		
	}

	void walkFast () {
		strangerSpeed = strangerSpeed + 3;
	}

	void walkSlow () {
		strangerSpeed = 0;
		Invoke("resumeWalk",1f);

	}

	void resumeWalk(){
		strangerSpeed = Random.Range (1,3);
	}

}
