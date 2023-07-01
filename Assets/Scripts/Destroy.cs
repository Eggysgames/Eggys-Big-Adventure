using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {


	void OnTriggerEnter2D (Collider2D col) {

		if(col.gameObject.tag == "Player") {
			Destroy (gameObject);
		}

	

	}


}
