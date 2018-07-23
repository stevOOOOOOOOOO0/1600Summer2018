using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class MissleLauncher : MonoBehaviour
{

	//the TransformData is a scriptable object
	private CharacterController missle;
	public TransformData Destination;
	//private Vector3 movement;
	//private float speed = 1f;
	
	// Use this for initialization
	void Start ()
	{
		missle = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		missle.transform.Translate(missle.transform.forward * 10 * Time.deltaTime);
		missle.transform.LookAt(Destination.Value);
	}
	
	/*private void getMovement()
	{
		
		
		
		if (missle.transform.position.x < Destination.Value.x && movement.x < 10)
		{
			movement.x += speed;
		}
		else if (missle.transform.position.x > Destination.Value.x && movement.x > -10)
		{
			movement.x -= speed;
		}
		if (missle.transform.position.y < Destination.Value.y && movement.y < 5)
		{
			movement.y += speed;
		}
		else if (missle.transform.position.y > Destination.Value.y && movement.y > -5)
		{
			movement.y -= speed;
		}
		if (missle.transform.position.z < Destination.Value.z && movement.z < 10)
		{
			movement.z += speed;
		}
		else if (missle.transform.position.z > Destination.Value.z && movement.z > -10)
		{
			movement.z -= speed;
		}
	}*/
}