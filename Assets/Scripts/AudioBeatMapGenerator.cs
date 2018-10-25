using UnityEngine;

public class AudioBeatMapGenerator : MonoBehaviour {

	public int bpm;
	public GameObject [] bongoCats;

	private float timer;
	private int bongoToHit = 0;
	void start () {
		timer = 60f / bpm;
	}

	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0f) {
			int value = Mathf.RoundToInt (AudioPeer._freqBand [5]);
			if (value < 3) {
				if (bongoToHit == 2) {
					bongoToHit = 1;
				} else {
					bongoToHit = 2;
				}
			} else {
				bongoToHit = 0;
			}
			print (bongoToHit);
			GameObject go = Instantiate (bongoCats [bongoToHit], transform.position, Quaternion.identity);
			go.name = go.name.Replace ("(Clone)", "");
			timer = 60f / bpm;
		}
	}
}
