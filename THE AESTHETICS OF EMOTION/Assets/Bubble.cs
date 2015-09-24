using UnityEngine;
using System.Collections;

public class Bubble : MonoBehaviour {

	Vector3 rate;
	bool shrink = false;
	Vector3 startSize;

	void Start () {
		rate = new Vector3(.0575f,.0575f,0f);
		startSize = transform.localScale;
	
	}
	
	// Update is called once per frame
	void Update () {

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
		FanSpeech.activeFan = Random.Range(1,40);
		gameObject.SetActive(false);

	}

}
