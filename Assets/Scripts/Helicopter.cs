using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

	
	private bool called = false;
	private Rigidbody rigi;

	// Use this for initialization
	void Start () {
		rigi = GetComponent<Rigidbody> ();
	}


	 void OnDispatchHelicopter(){		
		rigi.velocity = new Vector3 (0, 0, 50f);
		called = true;
	}

}
