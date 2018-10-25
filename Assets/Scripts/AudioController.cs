using UnityEngine;

public class AudioController : MonoBehaviour {

	private bool hitLeft = false;
	private bool hitRight = false;

	private bool left = false;
	private bool right = false;
	private bool both = false;

	private AudioSource theSong;
	void Start () {
		theSong = GetComponent<AudioSource> ();
	}

	void Update () {
		print ("hmmmm");
		if (left == hitLeft) {
			theSong.volume = 1;
		} else if (right == hitRight) {
			theSong.volume = 1;
		} else if (both == hitLeft && both == hitRight) {
			theSong.volume = 1;
		} else {
			theSong.volume = 0.2f;
		}
	}

	public void hit (string paw) {
		if (paw == "left") {
			print ("hit left");
			hitLeft = true;
		} else {
			print ("hit right");
			hitRight = true;
		}
	}

	public void bongoCatDown (string bongo) {
		if (bongo == "left") {
			left = true;
		} else if (bongo == "right") {
			right = true;
		} else {
			both = true;
		}
	}

}
