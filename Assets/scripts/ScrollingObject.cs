using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {

	private Rigidbody2D background;

	// Use this for initialization
	void Start () {
		background = GetComponent<Rigidbody2D>();
		background.velocity = new Vector2 (GameControl.instance.scrollSpeed,0);
	}
	
	// Update is called once per frame
	void Update () {
		if (GameControl.instance.gameOver == true) {
			background.velocity = Vector2.zero;
		}
	}
}
