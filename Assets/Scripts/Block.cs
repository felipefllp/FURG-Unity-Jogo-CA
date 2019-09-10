using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col) {
		Destroy (gameObject);
        BrickManager.instance.contzero--;
        GM.instance.CheckGameover();
        print(BrickManager.instance.contzero);
	}
}
