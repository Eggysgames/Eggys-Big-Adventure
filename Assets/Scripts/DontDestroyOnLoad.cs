using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour {

	//public AudioSource Music;

	private static DontDestroyOnLoad instance = null;
	public static DontDestroyOnLoad Instance {
		get { return instance; }
	}


	void Start () {

		//Music.Play ();
	//	if (GameObject.Find ("Background Music") == null) {
			//DontDestroyOnLoad (this);
			//Destroy (this.gameObject);

		if (instance != null && instance != this) {
			Destroy (this.gameObject);
			return;
		} else {

			instance = this; 

		}
		DontDestroyOnLoad (this.gameObject);


		}


	}
	


