using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour {

	public int currentEggs; 
	public int unlockamount; 
	public Collider2D myCollider; 

	public Canvas myCanvas; 
	private Animator myAnimator;
	public Animator myAnimator2;
	public GameObject myParticle;

	public AudioSource lightdown;

	void Start () {

		currentEggs = PlayerPrefs.GetInt ("totaleggs");
		myAnimator = GetComponent<Animator> ();
		myAnimator2 = myAnimator2.GetComponent<Animator> ();
		myCollider = GetComponent<Collider2D> ();

	}
	void LateUpdate() {
	
		currentEggs = PlayerPrefs.GetInt ("totaleggs");

	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Player") {

			//Debug.Log (currentEggs);
			//Debug.Log (unlockamount);

			if (currentEggs >= unlockamount) {

				lightdown.Play ();
				myCanvas.gameObject.SetActive (false);
				myParticle.SetActive (false);
				myAnimator.SetTrigger ("trigger");
				myAnimator2.SetTrigger ("trigger");
				Destroy (myCollider);

			}


		}
	}
}
