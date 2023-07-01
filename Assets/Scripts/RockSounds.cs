using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSounds : MonoBehaviour {

	public AudioSource Soccersound;
	public AudioSource Watersound;

	private float myrandom; 


	void OnCollisionEnter2D (Collision2D col) {

		if(col.gameObject.tag == "Ground") {

			if (col.relativeVelocity.magnitude > 4) {
				myrandom = Random.Range (0.1f, 2.5f);


				Soccersound.pitch = myrandom;
				Soccersound.Play ();
			}

		}
		if(col.gameObject.tag == "box") {

			if (col.relativeVelocity.magnitude > 4) {
				myrandom = Random.Range (0.1f, 2.5f);


				Soccersound.pitch = myrandom;
				Soccersound.Play ();
			}

		}



	}


	void OnTriggerEnter2D (Collider2D col) {

		if (col.gameObject.tag == "Water") {

			Watersound.Play ();

		}

	}
}
