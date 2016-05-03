// Michael O'Keefe
// Script for Little Planet, 3D Computer Graphics
// 
// Camera Movement Script is a component the Main Camera Game Object
// The script makes it so the Game Object is always focused on the 
// center (orgin) of the Planet, and the Game Object responds to 
// the user controls: W, A, S, D, Z, and X accordingly.
// 
// W: Move camera forward
// A: Move camera left
// S: Move camera backward
// D: Move camera right
// Z: Zoom in (limited by closest distance field)
// X: Zoom out (limited by furthest distance field)


using UnityEngine;
using System.Collections;

public class CameraMovementScript : MonoBehaviour {
	public float smooth = 15f;				// speed of movement
	public float closestDistance = 0.02f;	// closest distance limit
	public float furthestDistance = 1.0f;	// furthest distance limit
	private Transform planet;				// transform of the planet
	private Vector3 relCameraPos;			// camera position relative to planet

	// Update is called once per frame
	void Awake() {
		planet = GameObject.FindGameObjectWithTag ("Planet").transform; 
	}

	void FixedUpdate() {
		relCameraPos = planet.position - transform.position;
		transform.rotation = Quaternion.LookRotation (relCameraPos, transform.up);

		if (Input.GetKey (KeyCode.W))
			transform.position += smooth * transform.up * Time.deltaTime;

		if (Input.GetKey (KeyCode.S))
			transform.position -= smooth * transform.up * Time.deltaTime;

		if (Input.GetKey (KeyCode.A))
			transform.position -= smooth * transform.right * Time.deltaTime;

		if (Input.GetKey (KeyCode.D))
			transform.position += smooth * transform.right * Time.deltaTime;
		
		if (Input.GetKey (KeyCode.Z)) {
			Vector3 heading = transform.localPosition;

			// check if closet distance has been reached 
			if (heading.magnitude > closestDistance) 
				transform.position += smooth * transform.forward * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.X)) {
			Vector3 heading = transform.localPosition;

			// check if furthest distance has been reached
			if (heading.magnitude < furthestDistance)
				transform.position -= smooth * transform.forward * Time.deltaTime;
		}
	}
}
