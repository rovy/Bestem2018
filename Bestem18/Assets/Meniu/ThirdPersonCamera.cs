using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

	private const float Y_MIN_ANGLE = 10.0f;
	private const float Y_MAX_ANGLE = 50.0f;
	public Transform lookAt;
	public Transform camTransform;

	private Camera cam;

	private float distance = 0.50f;
	private float currentX;
	private float currentY;
    private float initialY;
	private float sensivityX = 7.0f; //4
	private float sensivityY = 6.0f; //3 

	private void Start(){
		camTransform = transform;
		cam = Camera.main;
        currentX = Camera.main.gameObject.transform.position.x;
        currentY = Camera.main.gameObject.transform.position.y;
        initialY = Camera.main.gameObject.transform.position.y; 
    }

	private void Update(){
		currentX += Input.GetAxis ("Mouse Y") * sensivityX;
		currentY += Input.GetAxis ("Mouse X") * sensivityY;

        currentX = Mathf.Clamp (currentX, Y_MIN_ANGLE, Y_MAX_ANGLE);
	}

	private void LateUpdate(){
		Vector3 dir = new Vector3 (0, 0, -distance);
		Quaternion rotation = Quaternion.Euler (currentX, currentY, 0);
        Vector3 positionToLook, positionToBe = lookAt.position;
        positionToLook = positionToBe = lookAt.position;
        positionToLook.y = 1.5f;
        positionToBe.z -= 0.5f;
        positionToBe.y = 1.5f;
        camTransform.position = positionToBe + rotation * dir;
        camTransform.LookAt(positionToLook);
    }
}
