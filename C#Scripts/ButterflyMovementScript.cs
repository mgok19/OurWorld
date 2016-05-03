// Michael O'Keefe
// Script for Little Planet, 3D Computer Graphics
// 
// Butterfly Movement Script is a component of all 
// Butterfly and Common Butterfly Game Objects
// The script makes it so those Game Objects rotate 
// around themselves while perpendicular to the Planet's 
// surface
//
// Rotation speed is random 

using UnityEngine;
using System.Collections;

public class ButterflyMovementScript : MonoBehaviour {
	private Vector3 heading; 

	void Start() {   
		// get heading from planet to object
		Vector3 planetPosition = GameObject.FindGameObjectWithTag ("Planet").transform.position;
		heading = planetPosition - transform.position;
	}

	void Update() {
		// rotate around itself
		transform.RotateAround (transform.position, -heading, Time.deltaTime * Random.Range(55, 65));
	}
}