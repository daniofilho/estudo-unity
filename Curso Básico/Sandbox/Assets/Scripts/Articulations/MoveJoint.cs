using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveJoint : MonoBehaviour {
	public SliderJoint2D slider;
	public JointMotor2D jointMotor;

	void Start() {
		jointMotor = slider.motor;
	}

	// Update is called once per frame
	void Update() {
		// Change motor speed to toggle directions
		if (slider.limitState == JointLimitState2D.LowerLimit) {
			jointMotor.motorSpeed = 1;
			slider.motor = jointMotor;
		}
		if (slider.limitState == JointLimitState2D.UpperLimit) {
			jointMotor.motorSpeed = -1;
			slider.motor = jointMotor;
		}
	}
}
