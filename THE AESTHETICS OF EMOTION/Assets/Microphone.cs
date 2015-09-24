using UnityEngine;
using System.Collections;

public class Microphone : MonoBehaviour {

	private RaycastHit hit;



	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 forward = transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast(transform.position, forward, out hit, Mathf.Infinity)) {
			if(hit.collider.tag == "Speech"){
				hit.collider.SendMessage("ExpandBubble");
				if(Input.GetButtonDown("AButton")){
					hit.collider.SendMessage("Pop");
				}
			}

	}
}
}
