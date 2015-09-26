using UnityEngine;
using System.Collections;

public class Bubble : MonoBehaviour {

	Vector3 rate;
	bool shrink = false;
	Vector3 startSize;
	
	public GameObject Blue;
	public GameObject Green;
	public GameObject Yellow;
	public GameObject Red;

	static public int colorNumber;

	void Start () {
		rate = new Vector3(.0575f,.0575f,0f);
		startSize = transform.localScale;
		colorNumber = Random.Range(0,5);
	
	}
	
	// Update is called once per frame
	void Update () {



		if(colorNumber <= 1){
			Blue.SetActive(true);
		}
		else{
			Blue.SetActive(false);
		}
		if(colorNumber == 2){
			Green.SetActive(true);
		}else{
			Green.SetActive(false);
		}
		if(colorNumber == 3){
			Yellow.SetActive(true);
		}
		else{
			Yellow.SetActive(false);
		}
		if(colorNumber >= 4){
			Red.SetActive(true);
		}
		else{
			Red.SetActive(false);
		}

		if (transform.localScale.y <= startSize.y){
			shrink = false;
		}

		if(shrink == true){
		transform.localScale -= rate;
		}

	}
	void ExpandBubble (){
		if(shrink == false){
		transform.localScale += rate * 2;
		}
		if(transform.localScale.y >= 1.5f){
			shrink = true;
		}
	}

	void Pop (){
		FanSpeech.activeFan = Random.Range(1,36);
		colorNumber = Random.Range(0,5);
		gameObject.SetActive(false);

	}

}
