using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

	private InputField firstInput;
	private InputField  middleInput;
	private InputField  lastInput;
	private Text helloMessage;
	private Button startButton;

	void Start() {
		firstInput = GameObject.FindGameObjectWithTag ("FirstInput").GetComponent<InputField>();
		middleInput = GameObject.FindGameObjectWithTag ("MiddleInput").GetComponent<InputField>();
		lastInput = GameObject.FindGameObjectWithTag ("LastInput").GetComponent<InputField>();
		helloMessage = GameObject.FindGameObjectWithTag ("HelloMessage").GetComponent<Text> ();
		startButton = GameObject.FindGameObjectWithTag ("StartButton").GetComponent<Button> ();
	}

	public void CheckCredentials() {
		if (firstInput.text.ToLower () == "christina" &&
		    middleInput.text.ToLower () == "rebecca" &&
		    lastInput.text.ToLower () == "vargas") {

			helloMessage.text = "Happy Anniversary, Christina";
			startButton.interactable = true;

		} else {
			
			helloMessage.text = "Unauthorized User";
			startButton.interactable = false;
		}
	}
}
