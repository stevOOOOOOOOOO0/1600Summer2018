using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTrigger : MonoBehaviour {
    
    public FloatData HealthLevel;
    public FloatData EvilPower;

	// Use this for initialization
	void Start ()
	{
		HealthLevel.Value = 1;
	}
	
	// Update is called once per frame
	void OnTriggerEnter () {
        HealthLevel.Value -= EvilPower.Value;
	}
}
