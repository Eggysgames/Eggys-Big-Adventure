using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TNT : MonoBehaviour {

	private Rigidbody2D tnt; 

	public int springheight; 
	public Transform Death; 
	public Transform Death2; 
	public GameObject BubbleSpawner; 
	public GameObject egg;
	public SpawnLimited script; 
	public Vector3 random;
	public GameObject SpawnMassEggs;



	void Start () {

		script = GameObject.FindWithTag("BubbleSpawner").GetComponent<SpawnLimited>();
		tnt = GetComponent<Rigidbody2D> (); 

	}


	void OnTriggerEnter2D (Collider2D col) {

		if (col.gameObject.tag == "Spring") {

			tnt.velocity = new Vector2 (tnt.velocity.x, 15);

		}

	}

	void OnCollisionEnter2D (Collision2D col) {

		if (col.gameObject.tag == "LittleEye") {

			script.CurrentAmount -= 1; 
			Instantiate (Death, transform.position, transform.rotation);
			Instantiate (Death2, col.transform.position, col.transform.rotation);
			Destroy (gameObject);
			Destroy (col.gameObject);
		}

		if (col.gameObject.tag == "BigEye") {

			script.CurrentAmount -= 1; 
			Instantiate (Death, transform.position, transform.rotation);
			Instantiate (Death2, col.transform.position, col.transform.rotation);


			for (int i = 0; i<20; i++) {




				random = new Vector3 (Random.Range (0, 12), 0, 0);
				Instantiate (egg, SpawnMassEggs.transform.position + random, SpawnMassEggs.transform.rotation);

			}




			Destroy (gameObject);
			Destroy (col.gameObject);

		}

	}

	void Update() {

		if (tnt.position.y < -50) {

			script.CurrentAmount -= 1; 
			Destroy (gameObject);


		}

	}

}
