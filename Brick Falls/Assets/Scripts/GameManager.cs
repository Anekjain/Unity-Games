﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {

	public float Slowness = 10f;

	public void EndGame () {
		StartCoroutine("RestartLevel");

	}
		
	IEnumerator RestartLevel () {

		Time.timeScale = 1f / Slowness;
		Time.fixedDeltaTime = Time.fixedDeltaTime / Slowness;

		yield return new WaitForSeconds (2f / Slowness);

		Time.timeScale = 1f;
		Time.fixedDeltaTime = Time.fixedDeltaTime * Slowness;


		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}
