// Michael O'Keefe
// Script for Little Planet, 3D Computer Graphics
// 
// Common Butterfly Script is a component of all 
// Common Butterfly Game Objects
// The script makes it so those Game Objects float up and 
// down on an axis perpendicular to the planet (creating the 
// illusion of flight) and sets a random animation speed

using UnityEngine;
using System.Collections;

public class CommonButterflyScript : MonoBehaviour {
	public float animationSpeed;		// animation speed
	public float floatSpeed;			// float speed
	public float maxHeight = 0.01f;		// limits max float height
	public float minHeight = 0.005f;	// limits min float height

	private bool floatUp = true;		// used for choosing direction to float
	private Vector3 toDirection;		// axis to float on 
	private Transform body;				// planets transform 

	void Start () {
		// set animation speed
		Animator animator = GetComponent<Animator> ();
		animator.speed = animationSpeed;

		// get axis to float on 
		body = GameObject.FindGameObjectWithTag ("Planet").GetComponent<Transform> ();
		toDirection = (body.position - transform.position).normalized;

	}

	void Update () {
		
		// float up
		if (transform.localPosition.magnitude < maxHeight && floatUp) {
			transform.localPosition += -toDirection * Time.deltaTime * floatSpeed;
		} else {
			floatUp = false;
		}

		// float down
		if (transform.localPosition.magnitude > minHeight && !floatUp) {
			transform.localPosition += toDirection * Time.deltaTime * floatSpeed;
		} else {
			floatUp = true;
		}
	}
}
