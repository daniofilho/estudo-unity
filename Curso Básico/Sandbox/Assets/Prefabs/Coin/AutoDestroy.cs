using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour {
	private float time = 1.5f;

	// Update is called once per frame
	void Update() {
		time -= Time.deltaTime;

		if (time <= 0) {
			Destroy(this.gameObject);
		}
	}
}
