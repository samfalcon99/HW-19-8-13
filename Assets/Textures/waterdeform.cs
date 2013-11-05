using UnityEngine;
using System.Collections;

public class waterdeform : MonoBehaviour {
	
	public float waveHeight = 0.5f;
	public float wavewidth = 0.5f;
	
	MeshFilter mf;
	Vector3[] baseVertices;
	Vector3[] workingCopy;

	// Use this for initialization
	void Start () {
		mf = GetComponent<MeshFilter>();
		baseVertices = mf.mesh.vertices;
	
	}
	
	// Update is called once per frame
	void Update () {
	workingCopy = baseVertices;
		
		for ( int i = 0; i < workingCopy.Length; i++ ) {
			workingCopy[i] = baseVertices[i] + Vector3.up * Mathf.Sin( Time.time + i ) * wavewidth  * waveHeight;
		}
		
		mf.mesh.vertices = workingCopy;
	}
}
