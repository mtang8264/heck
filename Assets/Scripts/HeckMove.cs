using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeckMove : MonoBehaviour {
	public float speed = 0.1f;
	private float initSpeed;
	private int dir = 0;
	public float speedMulti = 0.0001f;

	// Use this for initialization
	void Start () {
		initSpeed = speed;
	}
	
	// Update is called once per frame
	void Update () {
		speed = initSpeed + (speedMulti * Mathf.Pow (Time.time, 2f));

		transform.Translate(new Vector3 (0f, speed), Space.World);

		BorderCheck ();
	}

	public void BorderCheck(){
		if (dir % 2 == 0) {
			if (transform.position.x > 3) {
				transform.position = new Vector3 (3f, transform.position.y, transform.position.z);
			} else if (transform.position.x < -3) {
				transform.position = new Vector3 (-3f, transform.position.y, transform.position.z);
			}
		} else {
			if (transform.position.x > 4) {
				transform.position = new Vector3 (4f, transform.position.y, transform.position.z);
			} else if (transform.position.x < -4) {
				transform.position = new Vector3 (-4f, transform.position.y, transform.position.z);
			}
		}
	}
	public void MoveRight(){
		if(transform.position.x < 3 || (transform.position.x < 4 && dir % 2 == 1))
			transform.position = transform.position + new Vector3 (1f, 0f);
	}
	public void MoveLeft(){
		if (transform.position.x > -3 ||  (transform.position.x > -4 && dir % 2 == 1))
			transform.position = transform.position - new Vector3 (1f, 0f);
	}

	public void Rotate(){
		transform.Rotate (new Vector3 (0f, 0f, -90f));
		dir++;
		if (dir >= 4) {
			dir = 0;
			transform.rotation = new Quaternion ();
		}
	}
}
