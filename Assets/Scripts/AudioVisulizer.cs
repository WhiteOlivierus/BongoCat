using UnityEngine;

public class AudioVisulizer : MonoBehaviour {
	public GameObject visualCube;
	private GameObject [] visualCubes = new GameObject [AudioPeer._freqBand.Length];
	void Start () {
		Vector3 lastPos = transform.position;
		for (int i = 0; i < AudioPeer._freqBand.Length; i++) {
			Vector3 pos = lastPos += Vector3.right * 1.2f;
			GameObject go = Instantiate (visualCube, pos, visualCube.transform.rotation);
			go.transform.SetParent (transform);
			go.name = "visualCube" + i;
			visualCubes [i] = go;
			lastPos = pos;
		}
	}

	void Update () {
		for (int i = 0; i < visualCubes.Length; i++) {
			visualCubes [i].transform.localScale = new Vector3 (1, AudioPeer._freqBand [i], 1);
		}
	}
}
