using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PausedScript : MonoBehaviour {

	public GameObject PauseUI;
	private bool paused = false;
	private bool toggle = false;
	public Text mytext; 

	public AudioSource Cursorselect;

	void Start () {
		PauseUI.SetActive (false);

		if (AudioListener.volume == 0) {
			mytext.text = "Sound : Off";
			toggle = false; 
		}
		if (AudioListener.volume == 1) {
			mytext.text = "Sound : On";
			toggle = true; 
		}

		toggle = !toggle;
	}
	

	void Update () {
		
		if(Input.GetButtonDown("Pause")) {
			paused = !paused;
		}

		/////////////////////
		if (paused) {
			PauseUI.SetActive (true);
			Time.timeScale = 0; 
		}

		if (!paused) {
			PauseUI.SetActive (false);
			Time.timeScale = 1f;
		}
	}

	public void resume() {
		paused = !paused;
	}

	public void returnhome() {
		SceneManager.LoadScene ("Home"); 

	}

	public void returnmenu() {
		SceneManager.LoadScene ("_MainMenu"); 

	}

	public void GooglePlay() {
		Application.ExternalEval("window.open(\"https://play.google.com/store/apps/details?id=com.EggysGames.EggysBigAdventure2\",\"_blank\")");
	}

	public void mysound() {




		if (toggle == false) {
			mytext.text = "Sound : Off";
			AudioListener.volume = 0;
		
		}
		if (toggle == true) {
			mytext.text = "Sound : On";
			AudioListener.volume = 1;
		}

		toggle = !toggle;
	}

	public void playselectsound() {
		
		Cursorselect.Play ();

	}

}
