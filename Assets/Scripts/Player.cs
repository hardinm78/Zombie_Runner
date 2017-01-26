using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Transform playerSpawnPoints;
	public bool respawn = false;
	public GameObject landingAreaPrefab;

	private Transform[] spawnPoints;
	private bool lastToggle = false;



	// Use this for initialization
	void Start () {
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (lastToggle != respawn){
			Respawn ();
			lastToggle = respawn;
		}



	}

	private void Respawn(){
		int i = Random.Range (1, spawnPoints.Length);
		transform.position = spawnPoints [i].position;
	}

	void OnFindClearArea(){
		Invoke ("DropFlare", 3f);
	}

	void DropFlare(){
		Instantiate (landingAreaPrefab, transform.position, transform.rotation);
	}
}
