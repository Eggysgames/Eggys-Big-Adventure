using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEgg : MonoBehaviour {


	private Animator myAnimator;
	public Collider2D myCollider; 

	void Start () {

		myAnimator = GetComponent<Animator> ();
		myCollider = GetComponent<Collider2D> (); 
	}

	void OnTriggerEnter2D (Collider2D col) {
		if(col.gameObject.tag == "Player") {
			myAnimator.SetTrigger("death"); 
			Destroy (myCollider); 
		}

		}

	}
