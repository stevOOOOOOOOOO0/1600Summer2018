using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAmmo : MonoBehaviour {

   public GameObject Ammo;
   
	// Update is called once per frame
	void Update () {
      if (Input.GetKeyDown(KeyCode.Space))
         Instantiate(Ammo);
	}
}
