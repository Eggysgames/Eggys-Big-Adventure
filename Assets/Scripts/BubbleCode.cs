using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleCode : MonoBehaviour {

	private Rigidbody2D bubble;
	public float speed;

	void Start() {

		bubble = GetComponent<Rigidbody2D>(); 
		speed = Random.Range (1, 5);
	}



	void Update () {



		bubble.velocity = new Vector2 (bubble.velocity.x, speed);

		if (bubble.position.y > -37) {

			Destroy (gameObject);
		}

	}
}
