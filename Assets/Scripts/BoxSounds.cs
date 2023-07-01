using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSounds : MonoBehaviour {

	public AudioSource Soccersound;
	public AudioSource Watersound;

	private float myrandom; 

	void OnCollisionEnter2D (Collision2D col) {

		if(col.gameObject.tag == "Ground") {

			if (col.relativeVelocity.magnitude > 4) {
				myrandom = Random.Range (0.5f, 1.5f);


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
