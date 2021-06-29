using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDuck : MonoBehaviour {
	public float velocity = 2.5f;

	public int coins = 0;

	public GameObject coinSoundPrefab;

	public AudioClip coinSound;


	// Update is called once per frame
	void Update() {
		float horAxis = Input.GetAxis("Horizontal");

		transform.Translate(new Vector3(horAxis * velocity * Time.deltaTime, 0, 0));
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Coin")) {
			// instantiate coin sound effect
			//Instantiate(coinSound, new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z), Quaternion.identity); // Quaternion.identity => actual rotation

			// audio effect with an audio manager
			AudioManager.instance.PlayAudio(coinSound);

			coins++;
			Destroy(other.gameObject);
		}
	}
}
