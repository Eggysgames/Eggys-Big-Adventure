using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCode : MonoBehaviour {

	public Rigidbody2D bullet; 
	public Transform holder; 
	private int spawntime = 0;



	void Update() {

		spawntime++; 

		if (spawntime > 200) {
			Instantiate (bullet, holder.position, holder.rotation);
			spawntime = 0; 
		}


	}
	

}
