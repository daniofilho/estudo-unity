using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDuck : MonoBehaviour {
	public float velocity = 2.5f;

	public int coins = 0;


	// Update is called once per frame
	void Update() {
		float horAxis = Input.GetAxis("Horizontal");

		transform.Translate(new Vector3(horAxis * velocity * Time.deltaTime, 0, 0));
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Coin")) {
			coins++;
			Destroy(other.gameObject);
		}
	}
}
