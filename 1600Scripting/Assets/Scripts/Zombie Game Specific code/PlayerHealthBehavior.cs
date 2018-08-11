using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerHealthBehavior : MonoBehaviour
{

	public FloatData Health;
	public GameObject RestartButton;
	
	// Use this for initialization
	void Start () {
		Health.SetValue(1);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Zombie")
		{
			Health.SubValue(.1f);
		}

		if (Health.GetValue() <= 0)
		{
			GetComponent<ParticleSystem>().enableEmission = true;
			gameObject.SetActive(false);
			RestartButton.transform.localScale = new Vector3(1,1,1);
		}
	}
}
