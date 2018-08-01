using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthBehavior : MonoBehaviour
{

	public FloatData Health;
	//private CharacterController player;
	
	// Use this for initialization
	void Start () {
		Health.SetValue(1);
		//player = GetComponent<CharacterController>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Zombie")
		{
			Health.SubValue(.1f);
			Debug.Log("subtracting yo");
		}
	}
}
