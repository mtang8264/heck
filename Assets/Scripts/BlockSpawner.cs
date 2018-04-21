using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {
	public float lastSpawn = 10f;
	public GameObject[] blockOptions;
	private Transform heck;

	// Use this for initialization
	void Start () {
		heck = GameObject.FindWithTag ("Heck").GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = heck.position + new Vector3 (0f, 20f, 0f);

		if (lastSpawn + 40f < transform.position.y) {
			Debug.Log ("Could spawn");
			lastSpawn = transform.position.y;
			bool decision = Random.Range (-1f, 1f) > 0;
			if (decision)
				Spawn ();
		}
	}

	void Spawn () {
		int selection = Random.Range (0, blockOptions.Length);
		bool direction = Random.Range (-1f, 1f) >= 0;
		if (direction) {
			Instantiate (blockOptions [selection], transform.position, new Quaternion ()).transform.localScale = new Vector3 (1f, 1f, 1f);
		} else {
			Instantiate (blockOptions [selection], transform.position, new Quaternion ()).transform.localScale = new Vector3 (-1f, 1f, 1f);
		}
	}
}
