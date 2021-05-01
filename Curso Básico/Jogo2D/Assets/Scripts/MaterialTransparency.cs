using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialTransparency : MonoBehaviour {

	Material material;

	public float transparency = 0.5f;

	// Start is called before the first frame update
	void Start() {
		//material.color = new Color(1.0f, 1.0f, 1.0f, transparency);
		material = GetComponent<Renderer>().material;

	}

	void Update() {
		material.color = new Color(1.0f, 1.0f, 1.0f, transparency);
	}

}
