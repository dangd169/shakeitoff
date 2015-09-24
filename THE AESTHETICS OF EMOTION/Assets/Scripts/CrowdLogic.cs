using UnityEngine;
using System.Collections;

public class CrowdLogic : MonoBehaviour {

	GameObject Taylor;
	public GameObject Bullet;
	public GameObject BulletSpawn;
	//double startTime;
	//double timeElasped;

	// Use this for initialization
	void Start () {
		Taylor = GameObject.Find("Controller");
		//startTime = AudioSettings.dspTime;

		if(this.gameObject.name == ("Blue Fan")){
			Blue ();
		}
		
		if(this.gameObject.name == ("Yellow Fan")){
			Yellow ();
		}
		if(this.gameObject.name == ("Green Fan")){
			Green ();
		}
		if(this.gameObject.name == ("Red Fan")){
			Red ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		//Look at Taylor
		transform.LookAt(Taylor.transform);
		//Audio Time
		//timeElasped = AudioSettings.dspTime - startTime;
	}

	//Send Taylor love
	void Shoot() { 
		Instantiate(Bullet, BulletSpawn.transform.position, Quaternion.identity);
	}

	//Controls Blue bullets
	void Blue(){
		Invoke("Shoot", 0f);
		Invoke("Shoot", 4.5f);
		Invoke("Shoot", 6.3f);

	}

	//Controls Yellow bullets
	void Yellow(){
		Invoke("Shoot", .9f);
		Invoke("Shoot", 3.6f);
		Invoke("Shoot", 5.4f);

		
	}

	//Controls Green bullets
	void Green(){
		Invoke("Shoot", 1.8f);
		
	}

	//Controls Red bullets

	void Red(){
		Invoke("Shoot", 2.7f);


	}





}
