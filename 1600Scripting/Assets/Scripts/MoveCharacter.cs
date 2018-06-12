using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

    private CharacterController controller;
	
	private Vector3 newPosition;
	public float Speed = 10.0f;
	private float gravity = -20.0f;
    
	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		Speed += .01f;
		newPosition.z = Speed * Time.deltaTime;
		newPosition.y = gravity * Time.deltaTime;
		newPosition.x = Speed * Time.deltaTime * Input.GetAxis("Horizontal");
		controller.Move(newPosition);
	}
}
 