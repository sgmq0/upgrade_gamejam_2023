using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour {

	public void PlayGame() {
		SceneManager.LoadScene("Other menu");
	}
	
	public void Quit() {
		Debug.Log("Quit!");
		Application.Quit();
	}
	
	public void Donate() {
		Debug.Log("Donating");
		Application.OpenURL("YOUR DONATION PAGE");
	}
	
	public void VisitSite() {
		Application.OpenURL("YOUR SITE HERE");
	}
}