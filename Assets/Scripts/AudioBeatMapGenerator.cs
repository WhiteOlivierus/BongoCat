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
			int value = Mathf.RoundToInt (AudioPeer._freqBand [5]);
			int bongoToHit = 0;
			if (value < 5) {
				if (bongoToHit == 2) {
					bongoToHit = 1;
				} else {
					bongoToHit = 2;
				}
			} else {
				bongoToHit = 0;
			}
			print (bongoToHit);
			GameObject go = Instantiate (bongoCats [bongoToHit]);
			timer = 60f / bpm;
		}
	}
}
