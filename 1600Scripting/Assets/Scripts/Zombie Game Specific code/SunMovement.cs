using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMovement : MonoBehaviour
{

	private Light sun;

	void Start()
	{
		sun = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
