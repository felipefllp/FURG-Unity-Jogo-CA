﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) {
        GM.instance.LoseLife();
    }
}