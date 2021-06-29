using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBullets : MonoBehaviour {
	public GameObject bullets;
	public GameObject bulletOrigin;

	void Start() {

	}

	// Update is called once per frame
	void Update() {

		// instantiate bullets when Space is pressed
		if (Input.GetKeyDown(KeyCode.Space)) {
			Instantiate(bullets, new Vector3(bulletOrigin.transform.position.x, bulletOrigin.transform.position.y, 0), bulletOrigin.transform.rotation);
		}
	}
}
