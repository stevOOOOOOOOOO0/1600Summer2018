using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDirectionalBehavior : MonoBehaviour
{

	public Vector3 mousePosition;
	public Transform PlayerPosition;

	private void Start()
	{
		PlayerPosition = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		mousePosition = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		mousePosition.z = mousePosition.y;
		mousePosition.y = 1.08f;
		mousePosition.x += PlayerPosition.position.x - .5f;
		mousePosition.z += PlayerPosition.position.z - .5f;
		PlayerPosition.LookAt(mousePosition);
	}
}
