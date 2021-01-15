﻿using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	private float uThreshold;
	private float lThreshold;
	public Transform player;
  	public Vector3 offset;

	void Awake() {
		uThreshold = GameObject.Find("UpperCameraThreshold").transform.position.y;
		lThreshold = GameObject.Find("LowerCameraThreshold").transform.position.y;
	}

	void FixedUpdate () {
		// Camera follows the player with specified offset position
		if (player.position.y <= uThreshold && player.position.y >= lThreshold) {
			transform.position = new Vector3 (player.position.x + offset.x, player.position.y + offset.y, offset.z); 
		} else {
			transform.position = new Vector3 (player.position.x + offset.x, transform.position.y + offset.y, offset.z); 
		}
	}
}