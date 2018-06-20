using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTrigger : MonoBehaviour {
    
    public FloatData HealthLevel;

	// Use this for initialization
	void Start ()
	{
		HealthLevel.SetValue(1.0f);
	}

	// OnTriggerEnter is called once per frame
	private void OnTriggerEnter(Collider other)
	{
		if (other.name != "Player")
			HealthLevel.SubValue(.1f);
	}
}
