using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarkerMove : MonoBehaviour {
	public Transform heck;
	public int interval;
	public Text tex;

	// Use this for initialization
	void Start () {
		if (heck == null)
			heck = GameObject.FindWithTag ("Heck").GetComponent<Transform> ();
		interval = GameObject.FindGameObjectsWithTag ("Marker").Length * 10;
	}
	
	// Update is called once per frame
	void Update () {
		if (heck.position.y >= transform.position.y + 20f) {
			Progress ();
		}
	}

	void Progress () {
		transform.position = new Vector3(transform.position.x, transform.position.y + interval);
		tex.text = "" + transform.position.y + " m";
	}
}
