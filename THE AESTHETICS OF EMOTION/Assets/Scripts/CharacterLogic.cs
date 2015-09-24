using UnityEngine;
using System.Collections;

public class CharacterLogic : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other){

		if (other.gameObject.CompareTag("Bullet"))
			Destroy(other.gameObject);

		if (other.gameObject.CompareTag("Bullet 2"))
			Destroy(other.gameObject);

		if (other.gameObject.CompareTag("Bullet 3"))
			Destroy(other.gameObject);

		if (other.gameObject.CompareTag("Bullet 4"))
			Destroy(other.gameObject);
	}
}
