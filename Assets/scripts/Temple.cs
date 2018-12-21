using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temple : MonoBehaviour {

	private void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<ninja> () != null) {
			GameControl.instance.NinjaScore ();
		}
	}

	void  OnCollisionEnter2D ()
	{
		//ninja.isDead = true;
		GameControl.instance.NinjaDied ();
	}
}
