using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public void PlayGame() {
		Debug.Log("Start!");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}