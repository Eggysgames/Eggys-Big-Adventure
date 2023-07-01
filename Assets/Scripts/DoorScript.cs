using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;


public class DoorScript : MonoBehaviour {


	public bool beginlevel = false; 
	public Animator FadingOut; 
	public int timer = 0; 
	public Player script;
	public string scenetoload; 

	private bool hitting = false;
	private Animator myAnimator;

	public AudioSource doorsound;


	void Start () {
		myAnimator = GetComponent<Animator> ();
	}

	void Update () {

		if (Input.GetButtonDown ("Use") && hitting && script.grounded && beginlevel == false) {

			script.stop = true; 

			FadingOut.SetTrigger ("mytrigger2");
			myAnimator.SetTrigger ("mytrigger");
			beginlevel = true; 
			doorsound.Play ();

		}

		if (beginlevel == true) {
			timer++;

			if (timer > 20) {
				script.GetComponent<SpriteRenderer> ().enabled = false;
			}

			if (timer > 100) {

				SceneManager.LoadScene (scenetoload); 

			}

		} 

	}


	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag == "Player") {
			hitting = true; 
		}
	}

	void OnTriggerExit2D (Collider2D col) {
		if (col.gameObject.tag == "Player") {
			hitting = false;
		}

	}


}
