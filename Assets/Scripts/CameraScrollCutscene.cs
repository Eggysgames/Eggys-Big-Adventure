using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CameraScrollCutscene : MonoBehaviour {

	public float speed; 
	public int timer; 
	public int maintimer; 
	public Animator FadingOut;

	public AudioSource Narrator1;
	public AudioSource Narrator2;
	public AudioSource Narrator3;
	public AudioSource Narrator4;



	void Update () {

		maintimer++;

		if (maintimer == 10) {
			Narrator1.Play (); 
		}
		if (maintimer == 500) {
			Narrator2.Play (); 
		}
		if (maintimer == 900) {
			Narrator3.Play (); 
		}
		if (maintimer == 1500) {
			Narrator4.Play (); 
		}

		
		if (transform.position.x < 88) {
			transform.position = new Vector3 (transform.position.x + speed, transform.position.y, transform.position.z);
		}

		if (transform.position.x >= 87) {
			timer++; 
		}
		 
		if (timer > 220) {
			FadingOut.SetTrigger ("mytrigger2");
		}

		if (timer > 400) {
			SceneManager.LoadScene ("Home"); 
		}

		//Debug.Log (transform.position.x);

	}
}
