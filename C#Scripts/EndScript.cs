using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndScript : MonoBehaviour {

	void OnDestroy() {
		BackToStart ();
	}

	private IEnumerator BackToStart() {
		yield return new WaitForSeconds (60);
		SceneManager.LoadScene ("StartMenu");
	}
}
