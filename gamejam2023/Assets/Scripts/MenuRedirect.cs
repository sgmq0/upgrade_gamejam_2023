using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuRedirect : MonoBehaviour {

	public void PlayGame() {
		Debug.Log("Start!");
		SceneManager.LoadScene(0);
	}
}