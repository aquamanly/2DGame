using UnityEngine;
using System.Collections;

public class lookAtMouse : MonoBehaviour {
	public float speed;

	void FixedUpdate(){
		Plane playahPlane = new Plane (Vector3.up, transform.position);
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		float hitdist = 0.0f;
		if (playahPlane.Raycast (ray, out hitdist)) {
			Vector3 targetPoint = ray.GetPoint (hitdist);
			Quaternion targetRotation = Quaternion.LookRotation (targetPoint - transform.position);

			transform.rotation = Quaternion.Slerp (transform.rotation, targetRotation, speed * Time.deltaTime);
		}
	}


}
