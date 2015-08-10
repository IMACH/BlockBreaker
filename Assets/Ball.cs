﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public Paddle paddle; 
	private bool hasStarted; 

	private Vector3 paddleToBallVector;  
	// Use this for initialization
	void Start () {
		paddleToBallVector = (this.transform.position) - (paddle.transform.position); 
		print (paddleToBallVector); 
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			this.transform.position = paddle.transform.position + paddleToBallVector; 
			if (Input.GetMouseButtonDown (0)) {
					print ("Left mouse button clicked, launch ball"); 
					hasStarted = true; 
					this.rigidbody2D.velocity = new Vector2(2f,10f); 
			}
		}
		}

}