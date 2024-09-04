using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudaCamera : MonoBehaviour {
	public Camera cam1;
	public Camera cam2;


	// Use this for initialization
	void Start () {
		cam1.GetComponent<Camera> ().enabled = true;
		cam2.GetComponent<Camera> ().enabled = false;

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("c")){
			if (cam1.GetComponent<Camera> ().enabled == true) {
				cam1.GetComponent<Camera> ().enabled = false;
				cam2.GetComponent<Camera> ().enabled = true;

			} else if (cam2.GetComponent<Camera> ().enabled == true) {
				cam2.GetComponent<Camera> ().enabled = false;
				cam1.GetComponent<Camera> ().enabled = true;


			}

		}
	}
}