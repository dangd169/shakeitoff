using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

	public Image screenFade;
	public float alpha;

	// Use this for initialization
	void Start () {




	}
	
	// Update is called once per frame
	void Update () {

		screenFade.color = new Color(1,1,1,alpha);
		
		if (alpha > 0) {
			alpha -= .0000000000000005f * Time.deltaTime;
		}


	
	}
}
