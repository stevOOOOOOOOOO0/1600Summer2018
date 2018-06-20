using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{
	public WeaponsCollection Collection;

	private void OnTriggerEnter(Collider obj)
	{
		Collection.CollectWeapon(obj.GetComponent<WeaponObject>());
		Debug.Log(obj.GetComponent<WeaponObject>());
	}
}
