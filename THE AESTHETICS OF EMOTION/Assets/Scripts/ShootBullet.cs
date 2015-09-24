using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {

	public float speed = 5;
	GameObject Taylor;

	void Start () {
		Taylor = GameObject.Find("Target");
	}

	void Update () {
		transform.LookAt(Taylor.transform);
		transform.Translate(Vector3.forward * speed * Time.deltaTime);

	}

	void Reverse(){
		speed = -5;
	}

	}