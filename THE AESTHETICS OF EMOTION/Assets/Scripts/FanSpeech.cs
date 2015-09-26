using UnityEngine;
using System.Collections;

public class FanSpeech : MonoBehaviour {

	public int audienceMember;
	static public int activeFan;
	public GameObject bubble;

	// Use this for initialization
	void Start () {
		activeFan = Random.Range(1,36);
	}
	
	// Update is called once per frame
	void Update () {
		if(activeFan == audienceMember){
				bubble.SetActive(true);
		}
	
	}

}
