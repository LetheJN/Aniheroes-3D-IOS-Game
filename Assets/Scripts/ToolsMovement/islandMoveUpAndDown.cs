﻿using UnityEngine;
using System.Collections;

public class islandMoveUpAndDown : MonoBehaviour {

	float maxUpAndDown = 25;
	float speed = 25;            
	float angle = Mathf.PI; 
	float toDegrees = Mathf.PI / 170; 

	Vector3 origin;


	//	public GameObject player;
	//	private PlayerController playerScript;

	void Start(){
		//		playerScript = (PlayerController)player.GetComponent(typeof(PlayerController)); 

		origin = transform.position;
	}

	void Update () {
		//		if (playerScript.boxScore > 0) {

		angle += speed * Time.deltaTime;
		//		if (angle > 360) angle -= 360;
		origin.y = maxUpAndDown * Mathf.Sin (angle * toDegrees) - 28;
		transform.position = origin;
		//		}
	}
}
