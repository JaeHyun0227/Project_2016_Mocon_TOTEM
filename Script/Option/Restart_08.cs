﻿using UnityEngine;
using System.Collections;

public class Restart_08 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("Home");
            Application.LoadLevel("1-8Stage");
        }
    }
}
