using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour {
	public float force = 1000f; // Don't forget to consider the Mass of the RigidBody on this value!
	public Rigidbody2D ball;

	void Start() {

	}

	// Update is called once per frame
	void Update() {

		// Apply this only to a object with a tag "Ball"
		if (this.gameObject.CompareTag("Ball")) {
			if (Input.GetKeyDown(KeyCode.Space)) {
				// apply force to ball when space is pressed
				ball.AddForce(new Vector2(0, force * Time.deltaTime), ForceMode2D.Impulse);
			}
		}


	}
}
