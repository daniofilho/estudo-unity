using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float velocity = 2.5f;

	void Start() {

	}

	// Update is called once per frame
	void Update() {

		// ugly way
		/*
		// right
		if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(new Vector3(velocity * Time.deltaTime, 0, 0));
		// left
		if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(new Vector3(-velocity * Time.deltaTime, 0, 0));
		// up
		if (Input.GetKey(KeyCode.UpArrow)) transform.Translate(new Vector3(0, velocity * Time.deltaTime, 0));
		// down
		if (Input.GetKey(KeyCode.DownArrow)) transform.Translate(new Vector3(0, -velocity * Time.deltaTime, 0)); 
		*/

		// using Unity Input system

		// Keys


		float horAxis = Input.GetAxis("Horizontal");
		float verAxis = Input.GetAxis("Vertical");

		transform.Translate(new Vector3(horAxis * velocity * Time.deltaTime, 0, 0));
		transform.Translate(new Vector3(0, verAxis * velocity / 2 * Time.deltaTime, 0));


		// Mouse

		/*
		float mouseHorAxis = Input.GetAxis("Mouse X");
		float mouseVerAxis = Input.GetAxis("Mouse Y");

		transform.Translate(new Vector3(mouseHorAxis * Time.deltaTime, mouseVerAxis * Time.deltaTime, 0));
		*/
	}
}
