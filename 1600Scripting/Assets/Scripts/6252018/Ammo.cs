using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour {

   private Rigidbody projectile;
   public FloatData ProjectileSpeed;
   public FloatData ProjectileUpgrade;

	// Use this for initialization
	void OnEnable () {
      projectile = GetComponent<Rigidbody>();
      projectile.AddForce(0, 0, ProjectileSpeed.GetValue());
	  Invoke("DeactivateObject", 2);
	}

	private void DeactivateObject(){
		gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
      ProjectileSpeed = ProjectileUpgrade;
      projectile.AddForce(0, 0, ProjectileSpeed.GetValue());
   }
}
