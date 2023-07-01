using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour {

	private Rigidbody2D player; 

	public Rigidbody2D ActivateThis; 
	public int DistanceTrigger;

	void Start() {

		player = GetComponent<Rigidbody2D>(); 
		ActivateThis.isKinematic = true;

	}

	void Update () {

		if (player.position.x > DistanceTrigger) {
			ActivateThis.isKinematic = false;
		}

	}
}
