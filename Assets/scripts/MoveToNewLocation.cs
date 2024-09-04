using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToNewLocation : MonoBehaviour {
	
	Vector3 EndPoint;
	// Use this for initialization
	void Start () {
		EndPoint = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position,EndPoint,0.2f);
	}
	void NewPoint(Vector3 v){
		EndPoint = v;
	}
}
