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

			if(hit.collider.tag == "Green"){
				hit.collider.SendMessageUpwards("ExpandBubble");
				if(Input.GetButtonDown("AButton")){
					hit.collider.SendMessageUpwards("Pop");
				}
			}

			if(hit.collider.tag == "Blue"){
				hit.collider.SendMessageUpwards("ExpandBubble");
				if(Input.GetButtonDown("XButton")){
					hit.collider.SendMessageUpwards("Pop");
				}
			}

			if(hit.collider.tag == "Red"){
				hit.collider.SendMessageUpwards("ExpandBubble");
				if(Input.GetButtonDown("BButton")){
					hit.collider.SendMessageUpwards("Pop");
				}
			}
			if(hit.collider.tag == "Yellow"){
				hit.collider.SendMessageUpwards("ExpandBubble");
				if(Input.GetButtonDown("YButton")){
					hit.collider.SendMessageUpwards("Pop");
				}
			}
		

	}
}
}
