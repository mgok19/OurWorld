using UnityEngine;
using System.Collections;

public class Note : MonoBehaviour {

	//The Skin/Background of the GUIStyle
	public GUISkin mycustomSkin;
	//The Text Of The Note
	public string Text = "Insert Your Text Here!";

	public string TagName = "Note's tag";

	public string NextNote = "Next Note's tag";

	private GameObject nextNote;

	void Awake() {

		//AutoSet the Name

		transform.name = "Note";
		this.gameObject.tag = TagName;

	}

	void OnDestroy() {
		nextNote = GameObject.FindGameObjectWithTag (NextNote);
		if (this.tag == "InsideLetter") {
			nextNote.GetComponent<Light> ().enabled = true;
		} else {
			nextNote.GetComponent<Renderer> ().enabled = true; 
			nextNote.GetComponent<ObjectGravity> ().enabled = true;
			nextNote.GetComponent<BoxCollider> ().enabled = true;
		}
	}



}