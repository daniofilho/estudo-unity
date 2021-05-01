using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
	public float force = 1000f;
	public Rigidbody2D ball;
	public int jumps = 2;

	void Start() {

	}

	void OnCollisionEnter2D(Collision2D TargetObject) {
		// If hits the ground
		if (TargetObject.gameObject.CompareTag("Ground")) {
			jumps = 2;
		}
	}

	void Update() {
		if (Input.GetKeyDown(KeyCode.Space) && jumps > 0) {
			// apply force to ball when space is pressed
			ball.AddForce(new Vector2(0, force * Time.deltaTime), ForceMode2D.Impulse);
			jumps--;
		}
	}
}
