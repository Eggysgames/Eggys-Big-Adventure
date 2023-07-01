using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript2 : MonoBehaviour {

	public bool hittingplatform = false;
	public bool direction;
	public int timer;
	public int swoop = 0;
	public int swoopspeed; 
	public int timeramount;
	public int speed;
	public int spewtime; 
	public Vector3 random; 
	public GameObject eye; 

	private Rigidbody2D platform; 
	public Rigidbody2D player; 

	void Start () {

		platform = GetComponent<Rigidbody2D>(); 
		timer = 0;
		direction = false;

	}

	void Update () {
		timer++; 
		swoop++; 
		spewtime++; 


		if (spewtime > 300) {

			spew (); 
			spewtime = 0; 

		}

		if (swoop > 200) {
			swoopspeed = 1;
		}
		if (swoop > 300) {
			swoopspeed = 0;
		}
		if (swoop > 400) {
			swoopspeed = -1;
		}
		if (swoop > 500) {
			swoopspeed = 0;
			swoop = 0;
		}
	

		if (timer > timeramount && direction == false) {
			direction = true;
			timer = 0;
		}
		if (timer > timeramount && direction == true) {
			direction = false;
			timer = 0;
		}
		if (direction == false) {
			platform.velocity = new Vector2 (speed, -swoopspeed);
		}
		if (direction == true) {
			platform.velocity = new Vector2 (-speed, -swoopspeed);
		}


	}

	void spew() {

		for (int i = 0; i<3; i++) {

			random = new Vector3 (Random.Range (0, 2), 0, 0);
			Instantiate (eye, transform.position + random, transform.rotation);

		}

	}

	void OnCollisionStay2D (Collision2D col) {
		if(col.gameObject.tag == "Player") {
			hittingplatform = true;
		}
	}

	void OnCollisionExit2D (Collision2D col) {
		hittingplatform = false;
	}


	void LateUpdate() {

		if (hittingplatform == true) {
			if (direction == false) {
				player.velocity += new Vector2 (speed, 0);
			}
			if (direction == true) {
				player.velocity -= new Vector2 (speed, 0);
			}
		}

	}


}
