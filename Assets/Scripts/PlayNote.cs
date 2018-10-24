using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNote : MonoBehaviour {


	public float keyBias = 0.01f;
	public AudioClip toneClip;


	private float initRotation;
	private bool pressed = false;
	private List<GameObject> toneInstances;

	void Start () {
		initRotation = transform.localRotation.x;
	}

	void FixedUpdate () {

		if (initRotation < transform.localRotation.x + keyBias && !pressed) {
			GetComponent<Renderer> ().material.color = Color.blue;
			GameObject audioInstance = new GameObject ("");
			AudioSource audioTemp = audioInstance.AddComponent<AudioSource> ();
			audioTemp.clip = toneClip;
			audioTemp.Play ();
			pressed = true;
		} else {
			GetComponent<Renderer> ().material.color = Color.red;
			pressed = false;
		}
	}


}
