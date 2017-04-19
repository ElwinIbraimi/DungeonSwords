using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

	public float mouseSensitivity = 10;
	public Transform target;
	public float dstFromTarget = 2;
	public Vector2 pitchMinMax = new Vector2 (-40, 85);

	public float rotationSmoothTime = 0.12f;
	Vector3 rotationSmoothVelocity;
	Vector3 currentRotation;

	float yaw;
	float pitch;

	// Update is called once per frame
	void LateUpdate () {
		// dont show the mouse
		Cursor.visible = false;
		// takes the Mouse X input times the sensivity you set
		yaw += Input.GetAxis ("Mouse X") * mouseSensitivity;
		// takes the Mouse Y input times the sensivity you set
		pitch -= Input.GetAxis ("Mouse Y") * mouseSensitivity;
		// this is the maximum direction you can move the camera to
		pitch = Mathf.Clamp (pitch, pitchMinMax.x, pitchMinMax.y);

		// make it so that rotating the camera is smooth
		currentRotation = Vector3.SmoothDamp (currentRotation, new Vector3 (pitch,yaw), ref rotationSmoothVelocity, rotationSmoothTime);
		transform.eulerAngles = currentRotation;
		Vector3 targetRotation = new Vector3 (pitch, yaw);
		transform.eulerAngles = targetRotation;
		transform.position = target.position - transform.forward * dstFromTarget;
	}
}
