using UnityEngine;
using System.Collections;

public class endZone : MonoBehaviour {

	public GameObject Stranger;
	public GameObject StrangerLeft;
	public GameObject Spawn;
	public GameObject leftSpawn;

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
			Destroy(other.gameObject);
			Instantiate(Stranger, Spawn.transform.position, Spawn.transform.rotation);
		}

		if(other.tag == "StrangerLeft"){
			Destroy(other.gameObject);
			Instantiate(StrangerLeft, leftSpawn.transform.position, leftSpawn.transform.rotation);
		}

	}
}
