using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]

public class FloatData : ScriptableObject {

    public float Value;

	public float GetValue()
	{
		return Value;
	}

	public void SetValue(float newValue)
	{
		Value = newValue;
	}

	public void SubValue(float sub)
	{
		Value -= sub;
	}
	
}
