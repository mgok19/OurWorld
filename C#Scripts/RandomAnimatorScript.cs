// Michael O'Keefe
// Script for Little Planet, 3D Computer Graphics
// 
// Used by all Game Objects with an Animator component (common butterflies & fish)
// The script makes it so that the Game Object's animator's speed is set randomly 
// within the given range.


using UnityEngine;
using System.Collections;

public class RandomAnimatorScript : MonoBehaviour {
	public float minSpeed = 0.75f;	// minimum speed
	public float maxSpeed = 1.25f;	// maximum speed

	// Use this for initialization
	void Start () {
		Animator anim = GetComponent<Animator> ();
		anim.speed = Random.Range (minSpeed, maxSpeed);
	}
}
