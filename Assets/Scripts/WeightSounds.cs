using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightSounds : MonoBehaviour {


	public AudioSource ChainSound;


	private float myrandom; 




	void OnCollisionEnter2D (Collision2D col) {

		if(col.gameObject.tag == "Player") {

			if (col.relativeVelocity.magnitude > 5) {
				myrandom = Random.Range (0.5f, 1.5f);


				ChainSound.pitch = myrandom;
				ChainSound.Play ();
			}

		}

		if(col.gameObject.tag == "Soccerball") {

			if (col.relativeVelocity.magnitude > 5) {
				myrandom = Random.Range (1f, 1.5f);


				ChainSound.volume = 0.2f;
				ChainSound.pitch = myrandom;
				ChainSound.Play ();
			}

		}


	}



}
