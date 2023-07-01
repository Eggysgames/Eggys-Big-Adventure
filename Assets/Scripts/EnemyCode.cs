using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCode : MonoBehaviour {

	private Rigidbody2D enemy; 

	private bool direction = false; 

	public float eleft;
	public float eright;
	public int speed; 


	void Start () {

		enemy = GetComponent<Rigidbody2D>(); 

	}


	void Update () {

		if (enemy.position.x < eleft) {
			direction = true;
		}
		if (enemy.position.x > eright) {
			direction = false;
		}

		if (direction == false) {
			enemy.velocity = new Vector2 (-speed, enemy.velocity.y);
		}
		if (direction == true) {
			enemy.velocity = new Vector2 (speed, enemy.velocity.y);
		}
	
	}



}
