﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseHideEClickF : MonoBehaviour {

    // Use this for initialization
    void Start () {
        Cursor.visible = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKey("escape")) {
            Application.Quit();
        }
    }
}
