using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour {

	private CharacterController controller;
	private Vector3 position;
	private float Speed;
	public float Count;
	public FloatData Timer;
	public bool Right;
	
	// Use this for initialization
	void Start ()
	{
		controller = GetComponent<CharacterController>();
		if (Right)
			Speed = 10;
		else
			Speed = -10;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Count += Time.deltaTime;
		if (Count >= Timer.GetValue())
		{
			Speed = Speed * -1;
			Count = 0;
		}
		position.x = Speed * Time.deltaTime;
		controller.Move(position);
	}
}
 