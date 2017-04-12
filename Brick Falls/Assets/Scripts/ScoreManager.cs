using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public float scoreCounter = 0f;
	private float HighScore;
	public Text ScoreText;

	void OnTriggerEnter2D (Collider2D c) {
		if (c.gameObject.CompareTag ("Block")) {
			scoreCounter++;
			scoreCounter = scoreCounter - 0.75f;
			ScoreText.text = scoreCounter.ToString ();
	
		}

		if (HighScore < scoreCounter) {
			HighScore = (int)scoreCounter;
			PlayerPrefs.SetFloat ("HighScore", HighScore);
		}

	}

	void Start() {
		Debug.Log (PlayerPrefs.GetFloat("HighScore"));
	}




}
