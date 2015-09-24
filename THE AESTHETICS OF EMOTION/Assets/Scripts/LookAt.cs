using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {

	GameObject Taylor;

	// Use this for initialization
	void Start () {

		Taylor = GameObject.Find("Taylor");
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.LookAt(Taylor.transform);
	
	}
}
