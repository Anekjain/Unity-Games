using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	public void MenuButton () {
		SceneManager.LoadScene ("Menu");
	}
	
	// Update is called once per frame
	public void PlayAgainButton () {
		SceneManager.LoadScene ("Main");
	}

	public void ExitGame() {
		Application.Quit ();
	}
}
