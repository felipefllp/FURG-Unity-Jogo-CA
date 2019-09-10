using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseHideEClick : MonoBehaviour {

    public GameObject bg01;
    public GameObject bg02;

    // Use this for initialization
    void Start () {
        Cursor.visible = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            if (bg01.activeSelf) { 
                bg01.SetActive(false);
                bg02.SetActive(true);
            } else {
                if (bg02.activeSelf) {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
        }
        if (Input.GetKey("escape")) {
            Application.Quit();
        }
    }
}
