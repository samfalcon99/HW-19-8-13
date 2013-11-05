using UnityEngine;
using System.Collections;

public class respawn : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	}
	
	void OnTriggerEnter() {
		transform.position = new Vector3 ( -0.02f, 1.623f, -3.96f);
			
		}
	}