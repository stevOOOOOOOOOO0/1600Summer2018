﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

	
	// initilization of all variables
    private CharacterController controller;
	private Vector3 newPosition;
	private float Speed = 10.0f;
	private float gravity = -2.0f;
    
	// Use this for initialization M
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		// this is the Jump section y axiz
		if (Input.GetAxis("Jump") != 0.0f && controller.isGrounded)
			newPosition.y = (Input.GetAxis("Jump") * 40);
		else if (controller.isGrounded == false)
			newPosition.y += gravity;
		else
			newPosition.y = gravity;
		//this is the rest of the moving funcitons x and z axis
		Speed += .01f;
		newPosition.z = Speed;
		newPosition.x = Speed * Input.GetAxis("Horizontal");
		
		//all of the movement is applied to the character controller here
		controller.Move(newPosition  * Time.deltaTime);
	}
}
 