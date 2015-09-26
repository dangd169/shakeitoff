using UnityEngine;
using System.Collections;

public class BubbleHomeless : MonoBehaviour {
	
	Vector3 rate;
	bool shrink = false;
	Vector3 startSize;
	
	public GameObject Blue;
	public GameObject Green;
	public GameObject Yellow;
	public GameObject Red;

	public GameObject BlueQ;
	public GameObject GreenQ;
	public GameObject YellowQ;
	public GameObject RedQ;

	public GameObject BlueSkin;
	public GameObject GreenSkin;
	public GameObject YellowSkin;
	public GameObject RedSkin;

	public GameObject Exclaim;
	
	static public int colorNumber;
	
	void Start () {
		rate = new Vector3(.05f,.05f,0f);
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
			transform.localScale -= rate *.55f;
		}
		
	}
	void ExpandBubble (){
		if(shrink == false){
			transform.localScale += rate *.55f;
		}
		if(transform.localScale.y >= 1.5){
			shrink = true;
		}
	}
	
	void Pop (){
		colorNumber = Random.Range(0,5);
		gameObject.SetActive(false);
		
	}

	void PopDelayGreen(){
		GreenSkin.SetActive(true);
		GreenQ.SetActive(false);
		Invoke ("Pop",1f);
	}
	void PopDelayBlue(){
		BlueSkin.SetActive(true);
		BlueQ.SetActive(false);
		Invoke ("Pop",1f);
	}
	void PopDelayRed(){
		RedSkin.SetActive(true);
		RedQ.SetActive(false);
		Invoke ("Pop",1f);
	}
	void PopDelayYellow(){
		YellowSkin.SetActive(true);
		YellowQ.SetActive(false);
		Invoke ("Pop",1f);
	}

	void Wrong () {
		Exclaim.SetActive (true);
		YellowQ.SetActive(false);
		RedQ.SetActive(false);
		BlueQ.SetActive(false);
		GreenQ.SetActive(false);
		Invoke ("WrongPop",1f);
	}

	void WrongPop(){
		gameObject.SetActive(false);
	}


	

	

	
}
