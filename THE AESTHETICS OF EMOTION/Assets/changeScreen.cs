using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class changeScreen : MonoBehaviour {

	public AudioSource shakeitoff;
	public GameObject audience;
	public AudioSource audienceSound;
	public Image screenFade;
	public float alpha;

	// Use this for initialization

	// Update is called once per frame
	void Update () {

		//if(Input.GetButtonDown("AButton")){
		//	shakeitoff.Stop();
		//}

		if (!shakeitoff.isPlaying) {
			audienceSound.volume -= .20f * Time.deltaTime;
			Fade ();

		}
	
	}

	void Fade () {

		screenFade.color = new Color(1,1,1,alpha);

		if (alpha < 1) {
			alpha += .5f * Time.deltaTime;
		} else {
			Application.LoadLevel("homeless");
		}



	}


}
