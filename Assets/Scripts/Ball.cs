using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	private Paddle paddle; 
	private bool hasStarted; 

	private Vector3 paddleToBallVector;  
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();

		paddleToBallVector = (this.transform.position) - (paddle.transform.position); 
		print (paddleToBallVector); 
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			//Lock ball relative to paddle 
			this.transform.position = paddle.transform.position + paddleToBallVector; 

			//Wait for a mouse press to launch the ball.
			if (Input.GetMouseButtonDown (0)) {
					print ("Left mouse button clicked, launch ball");
					hasStarted = true; 
					this.rigidbody2D.velocity = new Vector2(2f,10f); 
			}
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
	//Ball does not trigger sound when hitting breakable bricks? not sure why 
		if(hasStarted == true){
			audio.Play(); 
		}
	}

}
