using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {
	
	// initilization of all variables
    private CharacterController controller;
	private Vector3 newPosition;
	private float Speed = 20.0f;
    
	// Use this for initialization M
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		//this is the rest of the moving funcitons x and z axis
		newPosition.z = Speed * Input.GetAxis("Vertical");
		newPosition.x = Speed * Input.GetAxis("Horizontal");
		newPosition.y = -1;
		
		//all of the movement is applied to the character controller here
		controller.Move(newPosition  * Time.deltaTime);
		FixAbilities();
	}

	// this should update the Active abilities
	private void FixAbilities()
	{
		
	}
}