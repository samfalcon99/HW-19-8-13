﻿using UnityEngine;
using System.Collections;

public class forward : MonoBehaviour {
	
	public float movespeed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector3.forward * movespeed);
		}
	}
}