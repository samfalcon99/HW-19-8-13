using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {
	
	public float speed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			transform.Translate (Vector3.up * speed);
		}
	}
}