using UnityEngine;

public class AudioPeer : MonoBehaviour {
	private AudioSource _audioSource;
	public static float [] _samples = new float [512];
	public static float [] _freqBand = new float [8];

	void Start () {
		_audioSource = GetComponent<AudioSource> ();
	}

	void Update () {
		GetSpectrumAudioSource ();
		MakeFrequencyBands ();
	}
	void GetSpectrumAudioSource () {
		_audioSource.GetSpectrumData (_samples, 0, FFTWindow.Blackman);
	}

	void MakeFrequencyBands () {
		int count = 0;
		for (int i = 0; i < _freqBand.Length; i++) {

			float average = 0f;
			int sampleCount = (int) Mathf.Pow (2, i) * 2;

			if (i == 7) {
				sampleCount += 2;
			}
			for (int j = 0; j < sampleCount; j++) {
				average += _samples [count] * (count + 1);
				count++;
			}
			average /= count;
			_freqBand [i] = average * 10;
		}
	}
}
