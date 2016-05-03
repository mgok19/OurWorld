// Michael O'Keefe
// Script for Little Planet, 3D Computer Graphics
// 
// Used by the Planet GameObject
// The script makes it so that any GameObject that has the Object Gravity
// Script as a component gravitates toward the center of the planet (should
// collide with surface)

using UnityEngine;
using System.Collections;

public class PlanetGravityScript : MonoBehaviour {

	public float gravity = -1F;	// gravity intensity 

	public void PlanetGravity(Transform body) {

		// get the length to the body object from the center of the planet
		Vector3 toDirection = (body.position - transform.position).normalized;
	
		Vector3 fromDirection = body.up;

		// rotate the object to be inline with the planet's surface 
		body.rotation = Quaternion.FromToRotation (fromDirection, toDirection) * body.rotation; 

		// add gravitational force
		Rigidbody rb = body.GetComponent<Rigidbody> ();
		rb.AddForce (gravity * toDirection);
	}
}
