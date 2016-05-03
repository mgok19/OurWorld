// Michael O'Keefe
// Script for Little Planet, 3D Computer Graphics
// 
// Used by the Planet GameObject
// The script makes it so that the Planet and all of its children
// (includs the camera) rotates around its y axis at the set speed.


using UnityEngine;
using System.Collections;

public class PlanetRotationScript : MonoBehaviour {
	public float rotationSpeed = 1F;	// rotation speed

	void Update () {
		Vector3 temp = transform.eulerAngles;
		temp.y += rotationSpeed * Time.deltaTime;
		transform.eulerAngles = temp;
	}
}
 