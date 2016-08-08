using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void hitPlay() {
		SceneManager.LoadScene ("Pinkman2");
	}

//	public void hitOptions() {
//		SceneManager.LoadScene ("Options");
//	}

	public void hitQuit() {
		Application.Quit ();
	}

//	public void hitBack() {
//		SceneManager.LoadScene ("MainMenu");
//	}


}
