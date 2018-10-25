using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatInput : MonoBehaviour {

	private AudioController ac;

	void Start () {
		ac = GameObject.Find ("Song").GetComponent<AudioController> ();
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "GameController") {
			ac.hit (gameObject.name);
		}
	}
}
