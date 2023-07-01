using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

	public Rigidbody2D bullet;
	public GameObject mybullet; 
	public int speed; 



	void Update () {
		
		bullet.velocity = new Vector2 (speed, bullet.velocity.y);

	}
		

	void OnCollisionEnter2D (Collision2D col) {

		if(col.gameObject.tag == "Ground") {
			Destroy(gameObject);
		}


	}
}
