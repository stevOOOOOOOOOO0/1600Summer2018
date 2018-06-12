using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour {

	private CharacterController controller;
	private float speed = 10.0f;
	private Vector3 position;
	public float count = 0f;
	
	// Use this for initialization
	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		count += Time.deltaTime;
		if (count >= 1.15)
		{
			speed = speed * -1;
			count = 0;
		}
		position.x = speed * Time.deltaTime;
		controller.Move(position);
	}
}
 