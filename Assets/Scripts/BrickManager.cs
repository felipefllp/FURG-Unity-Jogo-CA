using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour {

    public int rows;
    public int colums;
    public int contzero = 400;
    public GameObject brickPrefab;
    public GameObject brickPrefab2;
    public GameObject brickPrefab3;
    public GameObject brickPrefab4;
    public GameObject brickPrefab5;

    public static BrickManager instance = null;

    private List<GameObject> bricks = new List<GameObject>();

    private int[,] faseAtual = new int[20, 20];

    // Use this for initialization
    void Awake () {

        if (instance == null) {
            instance = this;
        }
        else {
            if (instance != this) {
                Destroy(gameObject);
            }
        }

        //ResetLevel();
	}

    public void SetFase(int[,] fase) {
        contzero = 400;
        for (int x = 0; x < 20; x++) {
            for (int y = 0; y < 20; y++) {
                faseAtual[y, x] = fase[y, x];

                if ((faseAtual[y, x] == 0) || (faseAtual[y, x] == 5)) {
                    contzero--;
                }

            }
        }
    }

	// Update is called once per frame
	void Update () {
		
	}

    public bool ZeroBricks() {

        if (contzero == 0) {
            return true;
        }
        else {
            return false;
        }
        
    }

    public void SetLevel()
    {
        Vector2 spawnPos = default(Vector2);
        int ver = 0;

        foreach (GameObject brick in bricks)
        {
            Destroy(brick);
        }
        bricks.Clear();

        for (int x = 0; x < 20; x++){
            for (int y = 0; y < 20; y++){

                if(faseAtual[y,x] != 0) {

                    GameObject brick = null;

                    if (faseAtual[y, x] == 2){
                        spawnPos = (Vector2)transform.position + new Vector2(x * 3 * (brickPrefab2.transform.localScale.x), -y * (brickPrefab2.transform.localScale.y));
                        brick = Instantiate(brickPrefab2, spawnPos, Quaternion.identity);
                    }
                    else{
                        if (faseAtual[y, x] == 3) {
                            spawnPos = (Vector2)transform.position + new Vector2(x * 3 * (brickPrefab3.transform.localScale.x), -y * (brickPrefab3.transform.localScale.y));
                            brick = Instantiate(brickPrefab3, spawnPos, Quaternion.identity);
                        }
                        else {
                            if (faseAtual[y, x] == 4) {
                                spawnPos = (Vector2)transform.position + new Vector2(x * 3 * (brickPrefab4.transform.localScale.x), -y * (brickPrefab4.transform.localScale.y));
                                brick = Instantiate(brickPrefab4, spawnPos, Quaternion.identity);
                            }
                            else {
                                if (faseAtual[y, x] == 5) {
                                    spawnPos = (Vector2)transform.position + new Vector2(x * 3 * (brickPrefab5.transform.localScale.x), -y * (brickPrefab5.transform.localScale.y));
                                    brick = Instantiate(brickPrefab5, spawnPos, Quaternion.identity);
                                }
                                else {
                                    spawnPos = (Vector2)transform.position + new Vector2(x * 3 * (brickPrefab.transform.localScale.x), -y * (brickPrefab.transform.localScale.y));
                                    brick = Instantiate(brickPrefab, spawnPos, Quaternion.identity);
                                }
                            }
                        }
                    }
                    ver++;

                    bricks.Add(brick);
                }
            }
        }



    }



}
