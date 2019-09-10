using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseHideEClick1 : MonoBehaviour {

    // Use this for initialization
    void Start () {
        Cursor.visible = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (Input.GetKey("escape")) {
            Application.Quit();
        }
    }
}
