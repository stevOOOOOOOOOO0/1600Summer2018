using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{

   private Rigidbody projectile;

	// Use this for initialization
	void OnEnable () 
	{
		projectile = GetComponent<Rigidbody>();
		projectile.AddForce(Vector3.forward * 100);
		Invoke("DeactivateObject", 2);
	}

	private void DeactivateObject(){
		gameObject.SetActive(false);
	}
}
