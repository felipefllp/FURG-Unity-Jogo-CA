using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block4 : MonoBehaviour {

    public int cont = 4;
    public Sprite vid02;
    public Sprite vid03;
    public Sprite vid04;

    void OnCollisionEnter2D(Collision2D col) {
        cont--;

        if (cont == 3) {
            GetComponent<SpriteRenderer>().sprite = vid02;
        }
        else {
            if (cont == 2) {
                GetComponent<SpriteRenderer>().sprite = vid03;
            }
            else {
                if (cont == 1) {
                    GetComponent<SpriteRenderer>().sprite = vid04;
                }
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
