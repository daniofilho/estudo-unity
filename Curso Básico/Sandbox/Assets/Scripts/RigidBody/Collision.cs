using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D TargetObject) {
		//void OnCollisionExit2D(Collision2D TargetObject) {
		if (TargetObject.gameObject.CompareTag("Object")) {
			Destroy(TargetObject.gameObject);
		}
	}
}
