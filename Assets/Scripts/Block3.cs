using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block3 : MonoBehaviour {

    public int cont = 3;
    public Sprite pla02;
    public Sprite pla03;

    void OnCollisionEnter2D(Collision2D col) {
        cont--;

        if (cont == 2) {
            GetComponent<SpriteRenderer>().sprite = pla02;
        }
        else {
            if (cont == 1) {
                GetComponent<SpriteRenderer>().sprite = pla03;
            }
        }

        if (cont < 1) {
		    Destroy (gameObject);
            BrickManager.instance.contzero--;
            GM.instance.CheckGameover();
            print(BrickManager.instance.contzero);
        }
    }
}
