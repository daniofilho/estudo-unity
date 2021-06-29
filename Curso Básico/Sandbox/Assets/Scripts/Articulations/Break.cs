using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour {
	public DistanceJoint2D ball;
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		// break component joint when A is pressed
		if (Input.GetKeyDown(KeyCode.A)) {
			ball.breakForce = 0;
		}
	}
}
