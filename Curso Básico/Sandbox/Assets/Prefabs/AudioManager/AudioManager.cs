using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	public AudioSource sounds;
	public static AudioManager instance = null;

	// runs always even if code is disabled
	void Awake() {
		// make sure there is only one instance of this class
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy(gameObject);
		}
	}

	public void PlayAudio(AudioClip clipAudio) {
		sounds.clip = clipAudio;
		sounds.Play();
	}
}
