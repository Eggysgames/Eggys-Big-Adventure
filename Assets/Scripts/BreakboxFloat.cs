using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakboxFloat : MonoBehaviour {

	private Animator myAnimator;
	public Player script;
	public Transform Death; 
	public Transform boxexplode; 


	void Start () {

		myAnimator = GetComponent<Animator> ();

	}

	void Update() {



	}

	void OnCollisionEnter2D (Collision2D col) {

		if(col.gameObject.tag == "Player") {

			Instantiate (Death, boxexplode.transform.position, boxexplode.transform.rotation); 

			myAnimator.SetTrigger ("press");
			Destroy (gameObject); 
		}




	}
}
