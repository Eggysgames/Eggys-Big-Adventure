using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Sticky : MonoBehaviour {

	public Vector3 holder;
	public GameObject target=null;

	void Start() {
		target = null;
	}


	void OnCollisionExit2D(Collision2D col) {

		target = null;

	}

	void LateUpdate() {

		if (target != null) {


			target.transform.position = transform.position + holder;



			Debug.Log (target.transform.position);
		}

	}
}
