using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehavior : MonoBehaviour
{
	public FloatData PlayerHealth;
	private Image healthBar;
	
	// Use this for initialization
	void Start ()
	{
		healthBar = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		healthBar.fillAmount = PlayerHealth.GetValue();
	}
}
