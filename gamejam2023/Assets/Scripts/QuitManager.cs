using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitManager : MonoBehaviour {
	
	public void Quit() {
		Debug.Log("Quit!");
		Application.Quit();
	}
	
	// public void VisitSite() {
	// 	Application.OpenURL("YOUR SITE HERE");
	// }
}