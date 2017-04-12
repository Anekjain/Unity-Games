using UnityEngine.UI;
using UnityEngine;

public class HighScore : MonoBehaviour {

	public Text HighScoreText;
	// Use this for initialization
	void Start () {
		
		float highscore = PlayerPrefs.GetFloat ("HighScore");
		HighScoreText.text = highscore.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
