using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public float restartDelay = 1f;
	public GameObject completeLevelUI;

	bool gameHasEnded = false;

	public void CompleteLevel() {
		completeLevelUI.SetActive (true);
	}

	public void EndGame() {
		if (gameHasEnded == false) {
			gameHasEnded = true;
			Debug.Log ("Game over");
			Invoke("Restart", restartDelay);
		}
	}

	void Restart() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
