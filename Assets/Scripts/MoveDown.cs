using UnityEngine;

public class MoveDown : MonoBehaviour {

	public float dificulty = 0.25f;
	private AudioController ac;

	void Start () {
		ac = GameObject.Find ("Song").GetComponent<AudioController> ();
	}

	void Update () {
		transform.position += Vector3.down * Time.deltaTime;
		if (transform.position.y <= dificulty) {
			ac.bongoCatDown (gameObject.name);

		}
		if (transform.position.y <= 0) {
			Destroy (gameObject);
		}

	}
}
