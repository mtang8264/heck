using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
	private Transform heck;
	public float offset = 0;

	// Use this for initialization
	void Start () {
		heck = GameObject.FindWithTag ("Heck").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (heck.position.y > offset + transform.position.y) {
			transform.position = new Vector3 (transform.position.x, heck.position.y-offset, -10f);
		}
	}
}
