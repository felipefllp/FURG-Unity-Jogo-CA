using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raquet : MonoBehaviour {

	public float speed;
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxisRaw ("Mouse X");
		GetComponent<Rigidbody2D> ().velocity = Vector2.right * h * speed;
	}
}
