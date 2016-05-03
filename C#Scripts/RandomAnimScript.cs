// Michael O'Keefe
// Script for Little Planet, 3D Computer Graphics
// 
// Used by all Game Objects with an Animation component (butterflies)
// The script makes it so that the Game Object's animation speed is set randomly 
// within the given range. And the animation is started at a random point in 
// the animation clip. 

using UnityEngine;
using System.Collections;

public class RandomAnimScript : MonoBehaviour {
	public string animName;			// animation name
	public float minSpeed = 0.75f;	// maximum speed
	public float maxSpeed = 1.25f;	// minimum speed

	void Start () {
		Animation anim = GetComponent<Animation> ();
		anim[animName].time = Random.Range(0.0f, anim[animName].length);
		anim [animName].speed = Random.Range (minSpeed, maxSpeed);
		anim.wrapMode = WrapMode.PingPong;
	}
}
