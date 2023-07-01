using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerballSound : MonoBehaviour {

	public AudioSource Soccersound;
	public AudioSource Watersound;

	public float myrandom; 




	void OnCollisionEnter2D (Collision2D col) {

		if(col.gameObject.tag == "Ground") {
			
				myrandom = Random.Range (1f, 1.5f);

				
				Soccersound.pitch = myrandom;
				Soccersound.Play ();
		}




	}


	void OnTriggerEnter2D (Collider2D col) {

		if (col.gameObject.tag == "Water") {

			Watersound.Play ();

		}

	}
}
