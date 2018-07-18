using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinUI : MonoBehaviour
{

	public IntData CoinsCollected;
	private Text coinText;
	
	// Use this for initialization
	void Start ()
	{
		coinText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		coinText.text = CoinsCollected.Value.ToString();
	}
}
