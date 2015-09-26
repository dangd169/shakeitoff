using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour 
{
	
	public float horizontalRotationSpeed = 50f;
	public float horizontalMin = -75f;
	public float horizontalMax = 75f;
	private float horizontalRotation = 0.0f;
	public float verticalRotationSpeed = 50f;
	public float verticalMin = -35f;
	public float verticalMax = 35f;
	private float verticalRotation = 0.0f;
	float z = 0.0f;
	float speedH;
	float speedV;
	public float diagonalSpeed = 35.0f;
	float startSpeedH;
	float startSpeedV;


	void Start() 
	{
		verticalRotation = transform.eulerAngles.x;
		horizontalRotation = transform.eulerAngles.y;
		z = transform.eulerAngles.z;
		startSpeedH = horizontalRotationSpeed;
		startSpeedV = verticalRotationSpeed;


	}
	
	void Update() 
	{
		horizontalRotation += Input.GetAxis("Horizontal") * horizontalRotationSpeed * Time.deltaTime;
		horizontalRotation = ClampAngle(horizontalRotation, horizontalMin, horizontalMax );

		verticalRotation += Input.GetAxis("Vertical") * verticalRotationSpeed * Time.deltaTime;
		verticalRotation = ClampAngle(verticalRotation, verticalMin, verticalMax );

		Quaternion newRotation = Quaternion.Euler(-verticalRotation, horizontalRotation, z );
		transform.rotation = newRotation;

		speedH = Input.GetAxisRaw("Horizontal");
		speedV = Input.GetAxisRaw("Vertical");

		if(speedH != 0 && speedV != 0 ){
			horizontalRotationSpeed = diagonalSpeed;
			verticalRotationSpeed = diagonalSpeed;

		}
		else{
			horizontalRotationSpeed = startSpeedH;
				verticalRotationSpeed = startSpeedV;
		}

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