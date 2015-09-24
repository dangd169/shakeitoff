using UnityEngine;
using System.Collections;

public class CrowdSpawner : MonoBehaviour {

	public Transform crowd;

	// Use this for initialization
	void Start () {

		for (int i = -10; i < 10; i++) {
			Instantiate(crowd, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
