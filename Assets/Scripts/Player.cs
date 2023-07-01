using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour {

	private Rigidbody2D player;
	private Animator myAnimator;

	private bool respawn = false;
	private bool direction = true;

	public Transform explodespawn;
	public bool stop = false;
	public int maxEggs = 20;
	public int currentEggs = 0;
	public Text EggsNumberText;
	public GameObject PauseUI;
	public bool myRenderer;
	public Transform spawn; 
	public Transform Death; 
	public Transform groundCheck;
	public Transform myleft;
	public Transform myright; 
	public float timeleft = 3f; 
	public float myvelocity; 
	public bool watered; 
	public bool grounded;
	public float myrandom;

	public AudioSource EggSound;
	public AudioSource EggCrackSound;
	public AudioSource Soccersound;
	public AudioSource Explode;
	public AudioSource Splashsound;
	public AudioSource cloudsound;

	public AudioListener mainsound;

	public int controls;

	[SerializeField] private float springheight = 0f; 
	[SerializeField] private float jumpheight = 0f;
	[SerializeField] private float speed = 0f;


	void Start () {






		player = GetComponent<Rigidbody2D>(); 
		myAnimator = GetComponent<Animator> ();
		myRenderer = GetComponent<SpriteRenderer> ();

		if (EggsNumberText != null) {
			EggsNumberText.text = "" + currentEggs + "/" + maxEggs;
		}
	

	}
		

	void Update () {


		//Debug.Log(1/Time.deltaTime); //Framerate

		//myRenderer = GetComponent<SpriteRenderer> ().enabled;

		if (myRenderer == true && PauseUI.activeInHierarchy == false && stop == false) {
			grounded = Physics2D.Linecast (myleft.position, myright.position, 1 << LayerMask.NameToLayer ("Ground"));
			watered = Physics2D.Linecast (myleft.position, myright.position, 1 << LayerMask.NameToLayer ("Water"));

			if (grounded == false && watered == true) {
				grounded = true;
			}

			myAnimator.SetBool ("grounded", grounded);
			float horizontal = Input.GetAxis ("Horizontal");
			///////////
			inputkeys (); 
			Movement (horizontal);
			flip (horizontal);
			myvelocity = player.velocity.y;
		}

		if (stop == true) {
			myAnimator.SetFloat ("speed",0);
			player.velocity = Vector3.zero;
		}


		//////////////////
		/////////////////
		if (respawn == true) {
			timeleft -= Time.deltaTime; 
			if (timeleft <= 0) {
				SceneManager.LoadScene (SceneManager.GetActiveScene().name);
			}
		}
		if (player.transform.position.y < -55) {
			dying (); 
		}
	}


	////////////////////////////////////////////////


	void flip(float horizontal) {
		if (horizontal > 0 && !direction || horizontal < 0 && direction) {
			direction = !direction;
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
	}

	void Movement(float horizontal) {
		player.velocity = new Vector2 (horizontal * speed, player.velocity.y);
		myAnimator.SetFloat ("speed", Mathf.Abs(horizontal));
	}
		
	void inputkeys() {
		if (Input.GetButtonDown ("Jump") && grounded) {
			player.velocity = Vector3.zero;
			player.AddForce (new Vector2 (0, jumpheight));
			myAnimator.SetTrigger ("press");
			////
		}
	}

	void dying() {
		if (respawn == false) {
			Instantiate (Death, explodespawn.transform.position, explodespawn.transform.rotation); 
			GetComponent<SpriteRenderer> ().enabled = false;
			respawn = true;
			timeleft = 3; 
			EggCrackSound.Play ();
		}
	}

		

	void OnCollisionEnter2D (Collision2D col) {

		if(col.gameObject.tag == "Spring") {
			player.AddForce (new Vector2 (0, springheight));
		}

		if(col.gameObject.tag == "Spike") {
			dying ();
		}
		if(col.gameObject.tag == "LittleEye") {
			dying ();
		}
		if(col.gameObject.tag == "Breakable" && grounded == false && myvelocity < -2) {
			myAnimator.SetTrigger ("forcepress");
			player.velocity = Vector3.zero;
			player.AddForce (new Vector2 (0, jumpheight));
			Explode.Play ();
		}
		if(col.gameObject.tag == "BreakableFloat" && grounded == false) {
			myAnimator.SetTrigger ("forcepress");
			player.AddForce (new Vector2 (0, 0));
			player.AddForce (new Vector2 (0, jumpheight));
			Explode.Play ();

		}
		if(col.gameObject.tag == "Soccerball") {

			if (col.relativeVelocity.magnitude > 4) {

				if (!Soccersound.isPlaying) {
					myrandom = Random.Range (1f, 1.5f);


					Soccersound.pitch = myrandom;
					Soccersound.Play ();
				}

			}
		}
		if(col.gameObject.tag == "cloud") {

			if (col.relativeVelocity.magnitude > 4) {

				if (!Soccersound.isPlaying) {
					myrandom = Random.Range (0.5f, 1.5f);


					cloudsound.pitch = myrandom;
					cloudsound.Play ();
				}

			}
		}

	}
		
	void OnTriggerEnter2D (Collider2D col) {

		if(col.gameObject.tag == "Eggs"){

			if (EggsNumberText != null) {
				currentEggs += 1; 
				EggsNumberText.text = "" + currentEggs + "/" + maxEggs; 

				EggSound.Play ();
				Destroy (col.gameObject, 1f);
			}

		}
		if(col.gameObject.tag == "Water") {

			Splashsound.Play ();

		}

	}




}