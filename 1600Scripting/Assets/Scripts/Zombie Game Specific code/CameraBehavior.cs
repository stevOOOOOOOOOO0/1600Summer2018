using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{

	public Transform PlayerPosition;
	private Transform cameraPosition;
	private Vector3 tempPosition;
	
	// Use this for initialization
	void Start ()
	{
		cameraPosition = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		tempPosition = PlayerPosition.position;
		tempPosition.y = 40;
		cameraPosition.position = tempPosition;
	}
}
