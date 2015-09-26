using UnityEngine;
using System.Collections;

public class citySpawn : MonoBehaviour {

	public GameObject taxiLeft;
	public GameObject taxiRight;
	public GameObject strangerLeft;
	public GameObject strangerRight;
	public GameObject farStrangerLeft;
	public GameObject farStrangerRight;
	
	void Start () {

		for(int i = 0; i < 10f; i++){
			Instantiate (strangerRight,
			             new Vector3(Random.Range(-50,35),
			            strangerRight.transform.position.y, 
			            strangerRight.transform.position.z),
			             strangerRight.transform.rotation);
			Instantiate (strangerLeft,
			             new Vector3(Random.Range(-50,35),
			            strangerLeft.transform.position.y ,
			            strangerLeft.transform.position.z),
			             strangerLeft.transform.rotation);

			Instantiate (farStrangerRight,
			             new Vector3(Random.Range(-50,35),
			            farStrangerRight.transform.position.y, 
			            farStrangerRight.transform.position.z),
			             farStrangerRight.transform.rotation);
			Instantiate (farStrangerLeft,
			             new Vector3(Random.Range(-50,35),
			            farStrangerLeft.transform.position.y ,
			            farStrangerLeft.transform.position.z),
			             farStrangerLeft.transform.rotation);


		

		
		}

		for(int i = 0; i < 10f; i+=2){

			Instantiate (taxiLeft,
			             new Vector3(Random.Range(-50,35),
			            taxiLeft.transform.position.y ,
			            taxiLeft.transform.position.z),
			             taxiLeft.transform.rotation);
			
			Instantiate (taxiRight,
			             new Vector3(Random.Range(-50,35),
			            taxiRight.transform.position.y ,
			            taxiRight.transform.position.z),
			             taxiRight.transform.rotation);

		}




	}
	void Update () {
	
	}
}
