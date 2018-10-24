using UnityEngine;

public class AudioBeatMapGenerator : MonoBehaviour {

	public int bpm;
	public GameObject [] bongoCats;

	private float timer;

	void start () {
		timer = 60f / bpm;
	}

	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0f) {
			GameObject go = Instantiate (bongoCats [0]);
			timer = 60f / bpm;
		}
	}
}
