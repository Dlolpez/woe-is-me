using UnityEngine;
using System.Collections;
public class FollowPlayer : MonoBehaviour {
	
	public Transform lookAt;
	private float distance = 244.0f;
	private float currentX = 0.0f;
	private float currentY = 60.0f;
	//private float sensitivityX = 1.0f;
	//private float sensitivityY = 1.0f;

	private void Update() {
		
		//currentX += cameraJoystick.InputDirection.x * sensitivityX;
		//currentY += cameraJoystick.InputDirection.z * sensitivityY;
	}
	private void LateUpdate() {
		Vector3 dir = new Vector3(currentX, currentY, -distance);
		//Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
		transform.position = lookAt.position + dir;
		//transform.LookAt(lookAt);
	}

}