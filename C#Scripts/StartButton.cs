using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {

	void Awake() {
		GetComponent<Button> ().interactable = false;
	}

	public void StartGame() {
		SceneManager.LoadScene ("InsideHouse");
	}
}