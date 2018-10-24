using UnityEngine;

public class MoveDown : MonoBehaviour {

	void Update () {
		transform.position += Vector3.down * Time.deltaTime;

		if (transform.position.y <= 0) {
			Destroy (gameObject);
		}
	}
}
