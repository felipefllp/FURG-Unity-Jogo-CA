using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block2 : MonoBehaviour {

    public int cont = 2;
    public Sprite mad02;

	void OnCollisionEnter2D(Collision2D col) {
        cont--;
        GetComponent<SpriteRenderer>().sprite = mad02;
        if (cont < 1) {
		    Destroy (gameObject);
            BrickManager.instance.contzero--;
            GM.instance.CheckGameover();
            print(BrickManager.instance.contzero);
        }
    }
}
