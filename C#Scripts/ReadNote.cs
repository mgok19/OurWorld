﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ReadNote : MonoBehaviour {

	//Your Custom GUI Skin :)
	private GUISkin mySkin;

	//Are we currently reading a note?
	private bool readingNote = false;

	//The text of the note we last read
	private string noteText;

	private bool open = false;

	void Start () {
		
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		//Start the input check loop
		StartCoroutine ( CheckForInput () );

	}

	private IEnumerator CheckForInput () {

		//Keep Updating
		while (true) {

			//If the 'E' was pressed and not reading a note check for a note, else stop reading
			if (Input.GetKeyDown (KeyCode.E)) {

				if (!readingNote)
					CheckForNote ();
				else
					readingNote = false;

			}

			//Wait One Frame Before Continuing Loop
			yield return null;

		}

	}

	private void CheckForNote () {
				
		//A ray from the center of the screen
		Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
		RaycastHit data;

		//Did we hit something?
		if (Physics.Raycast (ray, out data)) {

			if (data.transform.name == "Front_Door_a" && open) {
				SceneManager.LoadScene ("OneYearAnniversary");
			}

			//Was the object we hit a note?
			if (data.transform.name == "Note") {

				if (data.transform.GetComponent<Note> ().tag == "InsideLetter") {
					open = true;
				}
					
				//Get text of note, get custom GUIStyle FROM Note Script name must match,destroy the note, and set reading to true
				noteText = data.transform.GetComponent <Note> ().Text;
				mySkin = data.transform.GetComponent <Note> ().mycustomSkin;
				Destroy (data.transform.gameObject);
				readingNote = true;

			}

		}

	}
	// if followed by the name referenced at the top of script
	void OnGUI () {

		if (mySkin)
			GUI.skin = mySkin;

		//Are we reading a note? If so draw it.
		if (readingNote) {

			//Draw the note on screen, Set And Change the GUI Style To Make the Text Appear The Way you Like (Even on an image background like paper)
			GUI.Box (new Rect (Screen.width / 4F, Screen.height / 16F, Screen.width / 2F, Screen.height * 0.75F), noteText);

		}

	}

}
