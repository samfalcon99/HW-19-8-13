﻿using UnityEngine;
using System.Collections;

public class texturescroll : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public float scrollSpeed = 0.5F;
	void Update () {
		 float offset = Time.time * scrollSpeed;
        renderer.material.mainTextureOffset = new Vector2(offset, offset);
	
	}
}
