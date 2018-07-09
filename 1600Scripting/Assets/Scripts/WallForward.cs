using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallForward : MonoBehaviour
{

	private CharacterController controller;
	private Vector3 movement;
	private Vector3 Reset;

	// Use this for initialization
	void Start ()
	{
		controller = GetComponent<CharacterController>();
		movement = new Vector3(0,0,-15);
		Reset = new Vector3(0,0,20);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (controller.gameObject.transform.position.z <= -5f)
		{
			controller.Move(Reset);
		}
		controller.Move(movement * Time.deltaTime);
	}
}
