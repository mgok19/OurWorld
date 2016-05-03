// Michael O'Keefe
// Script for Little Planet, 3D Computer Graphics
// 
// Used by all game objects that touch the Planet's surface
// The script makes it so those Game Objects are pulled toward
// the center of the planet (should collide with surface of planet)

using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Rigidbody))]			
public class ObjectGravity : MonoBehaviour {
	
	private PlanetGravityScript planet;		// reference to planet's gravity

	public void Awake() { 

		// set a reference to the planet
		planet = GameObject.FindGameObjectWithTag ("Planet").GetComponent<PlanetGravityScript> ();

		// add rigid body
		GetComponent<Rigidbody> ().useGravity = false;
		GetComponent<Rigidbody> ().constraints = RigidbodyConstraints.FreezeRotation;
	}

	// activate gravity upon this object
	public void Update() {
		planet.PlanetGravity (transform);
	}

}
