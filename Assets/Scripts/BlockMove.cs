using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMove : MonoBehaviour {
	public GameObject[] BlockOptions;
	private Transform heck;

	// Use this for initialization
	void Awake () {
		heck = GameObject.FindWithTag ("Heck").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (heck.position.y > transform.position.y + 10f) {
			int selection = Random.Range (0, BlockOptions.Length);
			Instantiate(BlockOptions[selection], transform.position + new Vector3(0f,40f),new Quaternion());
			Destroy (gameObject);
		}
	}
}
