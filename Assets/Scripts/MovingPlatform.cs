using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

	public bool hittingplatform = false;
	public bool hittingground = false;
	public bool direction;
	public int timer;
	public int timeramount;
	public int speed;

	private Rigidbody2D platform; 
	public Rigidbody2D player; 

	void Start () {

		platform = GetComponent<Rigidbody2D>(); 
		timer = 0;
		direction = false;

	}

	void Update () {
		timer++; 
		if (timer > timeramount && direction == false) {

			direction = true;
			timer = 0;

		}
		if (timer > timeramount && direction == true) {

			direction = false;
			timer = 0;

		}
		if (direction == false) {
			platform.velocity = new Vector2 (speed, 0);
		}
		if (direction == true) {
			platform.velocity = new Vector2 (-speed, 0);
		}
	}

	void OnCollisionStay2D (Collision2D col) {
		if(col.gameObject.tag == "Player") {

			hittingplatform = true;

		}
		if(col.gameObject.tag == "Ground") {

			hittingground = true;

		}
	}



	void OnCollisionExit2D (Collision2D col) {
		if (col.gameObject.tag == "Player") {
			hittingplatform = false;
		}
		if (col.gameObject.tag == "Ground") {
			hittingground= false;
		}
	}

	void LateUpdate() {

		if (hittingground == false) {
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


}
