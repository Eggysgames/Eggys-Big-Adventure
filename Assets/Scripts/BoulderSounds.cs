using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderSounds : MonoBehaviour {

	public AudioSource Bouldersound;


	private float myrandom; 


	void OnCollisionEnter2D (Collision2D col) {

		if(col.gameObject.tag == "Spike") {

			if (col.relativeVelocity.magnitude > 2) {
				myrandom = Random.Range (0.5f, 1.5f);


				Bouldersound.pitch = myrandom;
				Bouldersound.Play ();
			}

		}
		if(col.gameObject.tag == "Ground") {

			if (col.relativeVelocity.magnitude > 5) {
				myrandom = Random.Range (0.5f, 1.5f);


				Bouldersound.pitch = myrandom;
				Bouldersound.Play ();
			}

		}
		if(col.gameObject.tag == "box") {

			if (col.relativeVelocity.magnitude > 6) {
				myrandom = Random.Range (0.5f, 1.5f);


				Bouldersound.pitch = myrandom;
				Bouldersound.Play ();
			}

		}


	}


	void OnTriggerEnter2D (Collider2D col) {



	}
}
