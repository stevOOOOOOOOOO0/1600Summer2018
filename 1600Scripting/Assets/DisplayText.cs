using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{

	public FloatData Health;
	
	// Update is called once per frame
	void Update ()
	{
		if (Health.GetValue() <= 0)
		{
			GetComponent<Text>().text = "DEAD";
		}
	}
}
