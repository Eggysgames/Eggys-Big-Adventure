using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechAppear : MonoBehaviour {


	public GameObject speech;

	public AudioSource playsound;

	void Start () {

		speech.SetActive (false); 

	}

	void OnTriggerEnter2D (Collider2D col) {

		if(col.gameObject.tag == "Player") {
			speech.SetActive (true); 

			if (!playsound.isPlaying) {
				playsound.Play (); 
			}

		}
	}


	void OnTriggerExit2D (Collider2D col) {

		if(col.gameObject.tag == "Player") {
			speech.SetActive (false); 
		}
	}
}
