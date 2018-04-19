using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockColor : MonoBehaviour {
	public SpriteRenderer[] bricks;
	public Sprite[] brickOptions;

	// Use this for initialization
	void Awake () {
		int randomSelect = Random.Range(0, brickOptions.Length);
		for (int i = 0; i < bricks.Length; i++) {
			bricks [i].sprite = brickOptions [randomSelect];
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
