using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhileLoops : MonoBehaviour
{

	public Text DisplayText;
	public int i = 3;
	
	// Use this for initialization
	void Start ()
	{
		
		StartCoroutine(Ticker());
	}

	IEnumerator Ticker()
	{
		while (i > 0)
		{
			DisplayText.text = i.ToString();
			yield return new WaitForSeconds(1);
			i--;
		}
		DisplayText.text = "GOOOOOOOO";
		yield return new WaitForSeconds(2);
		DisplayText.enabled = false;
	}
}
