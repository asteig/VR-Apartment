using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWaypoints : MonoBehaviour {

	public GameObject camera1;
	public GameObject camera2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("clicked!");
			camera1.gameObject.active = !camera1.gameObject.active; 
			camera2.gameObject.active = !camera2.gameObject.active; 
			Debug.Log (camera1.gameObject.active);
		}
	}
}
