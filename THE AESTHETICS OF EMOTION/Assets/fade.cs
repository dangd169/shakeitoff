using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fade : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Cross () {
		this.GetComponent<Image>().CrossFadeAlpha (1,1f, false);
	}
}
