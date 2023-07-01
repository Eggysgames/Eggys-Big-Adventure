using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour {

	private Animator myAnimator;

	public AudioSource SpringSound;

	void Start () {
		myAnimator = GetComponent<Animator> ();

	}
	

	void OnCollisionEnter2D (Collision2D col) {

		if(col.gameObject.tag == "Player") {
			myAnimator.SetTrigger ("press");

			SpringSound.Play ();

		}

	}

	void OnTriggerEnter2D (Collider2D col) {

		if(col.gameObject.tag == "TNT") {
			myAnimator.SetTrigger ("press");
		}


	}



}
