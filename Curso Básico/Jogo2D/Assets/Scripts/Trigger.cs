using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {
	public bool allowRotation = false;
	public GameObject targetObject;

	void Start() {

	}

	// Update is called once per frame
	void Update() {
		if (allowRotation) {
			targetObject.transform.Rotate(new Vector3(0, 0, 50 * Time.deltaTime));
		}
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Duck")) {
			allowRotation = true;
		}
	}

	private void OnTriggerExit2D(Collider2D other) {
		if (other.gameObject.CompareTag("Duck")) {
			allowRotation = false;
		}
	}
}
