using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallMovement : MonoBehaviour {

	private CharacterController controller;
	public FloatData InitialSpeed;
	private float speed;
	private Vector3 position;
	public float Count;
	public FloatData CountLength;
	
	// Use this for initialization
	void Start ()
	{
		controller = GetComponent<CharacterController>();
		speed = InitialSpeed.Value;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Count += Time.deltaTime;
		if (Count >= CountLength.Value)
		{
			speed = speed * -1;
			Count = 0;
		}
		position.x = speed * Time.deltaTime;
		controller.Move(position);
	}
}
 