using UnityEngine;
using System.Collections;

public class back : MonoBehaviour {
	
	public float speed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.S)) {
			transform.Translate (Vector3.back * speed);
			
		}
	}
}
