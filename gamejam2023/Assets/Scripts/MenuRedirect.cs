using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuRedirect : MonoBehaviour {

	public void MainMenu() {
		Debug.Log("Menu!");
		SceneManager.LoadScene(0);
	}
}