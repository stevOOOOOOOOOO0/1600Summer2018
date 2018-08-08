using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{

   private Rigidbody projectile;

	// Use this for initialization
	void OnEnable () 
	{
		Invoke("DeactivateObject", 2);
	}

	private void DeactivateObject(){
		gameObject.SetActive(false);
	}

	private void OnTriggerEnter(Collider other)
	{
		DeactivateObject();
//		if (other.tag == "Zombie")
//		{
//			//this will create zombies
//		}
	}
}
