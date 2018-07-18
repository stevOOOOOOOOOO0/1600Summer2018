using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MissleLauncher : MonoBehaviour
{

	private CharacterController Missle;
	public Transform Destination;
	private Vector3 movement;
	private float speed = 1f;
	
	// Use this for initialization
	void Start ()
	{
		Missle = GetComponent<CharacterController>();
		movement = new Vector3(10, 10, -10);
	}
	
	// Update is called once per frame
	void Update ()
	{
		Missle.Move(movement * Time.deltaTime);
		getMovement();
	}

	private void getMovement()
	{
		if (Missle.transform.position.x < Destination.position.x && movement.x < 10)
		{
			movement.x += speed;
		}
		else if (Missle.transform.position.x > Destination.position.x && movement.x > -10)
		{
			movement.x -= speed;
		}
		if (Missle.transform.position.y < Destination.position.y && movement.y < 10)
		{
			movement.y += speed;
		}
		else if (Missle.transform.position.y > Destination.position.y && movement.y > -10)
		{
			movement.y -= speed;
		}
		if (Missle.transform.position.z < Destination.position.z && movement.z < 10)
		{
			movement.z += speed;
		}
		else if (Missle.transform.position.z > Destination.position.z && movement.z > -10)
		{
			movement.z -= speed;
		}
	}
}
