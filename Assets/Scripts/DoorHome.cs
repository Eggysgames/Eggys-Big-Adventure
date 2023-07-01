using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;


public class DoorHome : MonoBehaviour {


	public bool beginlevel = false; 
	public Animator FadingOut; 
	public int timer = 0; 
	public Player script;
	public Text EggsNumberText;
	public int EggsHolder;

	private bool hitting = false;
	private Animator myAnimator;

	public AudioSource doorsound;

	void Start () {
		script = GameObject.FindWithTag("Player").GetComponent<Player>();
		myAnimator = GetComponent<Animator> ();
	}

	void Update () {



		if (Input.GetButtonDown ("Use") && hitting && beginlevel == false) {

			script.stop = true; 

			FadingOut.SetTrigger ("mytrigger2");
			myAnimator.SetTrigger ("mytrigger");
			beginlevel = true; 

			doorsound.Play ();

		}

		if (beginlevel == true) {
			timer++;

			if (timer > 20) {
				script.GetComponent<SpriteRenderer> ().enabled = false;
			}

			if (timer > 100) {

				Scene scene = SceneManager.GetActiveScene ();


				if (scene.name == "Level1") {
					PlayerPrefs.SetInt("spawn", 2);
				}
				if (scene.name == "Level2") {
					PlayerPrefs.SetInt("spawn", 3);
				}
				if (scene.name == "Level3") {
					PlayerPrefs.SetInt("spawn", 4);
				}
				if (scene.name == "Level4") {
					PlayerPrefs.SetInt("spawn", 5);
				}
				if (scene.name == "Level5") {
					PlayerPrefs.SetInt("spawn", 6);
				}
				if (scene.name == "Level6") {
					PlayerPrefs.SetInt("spawn", 7);
				}
				if (scene.name == "Level7") {
					PlayerPrefs.SetInt("spawn", 8);
				}
				if (scene.name == "Level8") {
					PlayerPrefs.SetInt("spawn", 9);
				}
				if (scene.name == "Level9") {
					PlayerPrefs.SetInt("spawn", 10);
				}
				if (scene.name == "Level10") {
					PlayerPrefs.SetInt("spawn", 11);
				}
				if (scene.name == "Level11") {
					PlayerPrefs.SetInt("spawn", 12);
				}
				if (scene.name == "Level12") {
					PlayerPrefs.SetInt("spawn", 13);
				}
				if (scene.name == "Level13") {
					PlayerPrefs.SetInt("spawn", 14);
				}
				if (scene.name == "Level14") {
					PlayerPrefs.SetInt("spawn", 15);
				}
				if (scene.name == "Level15") {
					PlayerPrefs.SetInt("spawn", 16);
				}
				if (scene.name == "Level16") {
					PlayerPrefs.SetInt("spawn", 17);
				}
				if (scene.name == "Level17") {
					PlayerPrefs.SetInt("spawn", 18);
				}
				if (scene.name == "Level18") {
					PlayerPrefs.SetInt("spawn", 19);
				}
				if (scene.name == "Level19") {
					PlayerPrefs.SetInt("spawn", 20);
				}
				if (scene.name == "Level20") {
					PlayerPrefs.SetInt("spawn", 21);
				}
				if (scene.name == "Level21") {
					PlayerPrefs.SetInt("spawn", 22);
				}
				//////
				if (scene.name == "Secret1") {
					PlayerPrefs.SetInt("spawn", 24);
				}
				/////
				if (scene.name == "House") {
					PlayerPrefs.SetInt("spawn", 1);
				}
				if (scene.name == "House2") {
					PlayerPrefs.SetInt("spawn", 25);
				}
				if (scene.name == "House3") {
					PlayerPrefs.SetInt("spawn", 26);
				}
				/////

				/////
				PlayerPrefs.SetInt("holdeggs", script.currentEggs);
				///
				if (scene.name == "Level22") {
					PlayerPrefs.SetInt ("spawn", 23);
					if (script.currentEggs >= 1) {
						SceneManager.LoadScene ("Z_Ending"); 
					}
					else {
						SceneManager.LoadScene ("Home"); 
					}
				} 
					
				else {
					SceneManager.LoadScene ("Home"); 
				}


			}

		} 

	}


	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag == "Player") {
			hitting = true; 
		}

	}
	void OnTriggerExit2D (Collider2D col) {
		if (col.gameObject.tag == "Player") {
			hitting = false;
		}

	}


}
