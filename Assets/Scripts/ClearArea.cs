using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {

	private float timeSinceLastTrigger = 0f;
	private bool foundClearArea = false;

		
	
	void Update () {
		timeSinceLastTrigger += Time.deltaTime;
		//print (timeSinceLastTrigger);
		if(timeSinceLastTrigger > 1 && Time.realtimeSinceStartup > 10f && !foundClearArea){
			SendMessageUpwards("OnFindClearArea");
			print ("found clear area");
			foundClearArea = true;

		}
	}

	void OnTriggerStay (Collider other)
	{
		if (other.tag != "Player") {
			timeSinceLastTrigger = 0f;
		}
	}

}
