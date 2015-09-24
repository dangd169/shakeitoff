using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour 
{

	//public float speed = 1000f;
	public float horizontalRotationSpeed = 50.0f;
	public float horizontalMin = -75f;
	public float horizontalMax = 75f;
	private float horizontalRotation = 0.0f;

	public float verticalRotationSpeed = 30.0f;
	public float verticalMin = -35f;
	public float verticalMax = 35f;
	private float verticalRotation = 0.0f;

	private float z = 0.0f;



	
	void Start() 
	{
		verticalRotation = transform.eulerAngles.x;
		horizontalRotation = transform.eulerAngles.y;
		z = transform.eulerAngles.z;
	}
	
	void Update() 
	{
		horizontalRotation += Input.GetAxis("RightHorizontal") * horizontalRotationSpeed * (Time.deltaTime * 1.15f);
		horizontalRotation += Input.GetAxis("Horizontal") * horizontalRotationSpeed * (Time.deltaTime *1.15f);
		horizontalRotation = ClampAngle(horizontalRotation, horizontalMin, horizontalMax );

		verticalRotation += Input.GetAxis("RightVertical") * horizontalRotationSpeed * Time.deltaTime;
		verticalRotation += Input.GetAxis("Vertical") * horizontalRotationSpeed * Time.deltaTime;
		verticalRotation = ClampAngle(verticalRotation, verticalMin, verticalMax );

		Quaternion newRotation = Quaternion.Euler(-verticalRotation, horizontalRotation, z );
		transform.rotation = newRotation;
	}
	
	float ClampAngle( float angle, float min, float max )
	{
		if ( angle < -360 )
			angle += 360;
		if ( angle > 360 )
			angle -= 360;
		
		return Mathf.Clamp( angle, min, max );
	}
}