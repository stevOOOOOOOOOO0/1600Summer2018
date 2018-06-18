using System.Collections;
using UnityEngine;

public class MaterialColorChange : MonoBehaviour {
	
	private Color colorStart;
	private Color colorEnd;
	private Material mat;
	private float red = 1;
	private float green;
	private float blue;
	private int count;
	private int RGB;

	/*********************************
	* Use this for initialization
	*********************************/
	void Start ()
	{
		mat = GetComponent<Renderer>().material;
	}
	
	/*************************************
	* Update is called once per frame
	*************************************/
	void Update ()
	{
	
	/************************************
	* Basically a Switch to determine which color to increase or decrease
	************************************/

		switch (RGB)
		{
			case 0:
				green += .01960784313f;
				break;
			case 1:
				red -= .01960784313f;
				break;
			case 2:
				blue += .01960784313f;
				break;
			case 3:
				green -= .01960784313f;
				break;
			case 4:
				red += .01960784313f;
				break;
			case 5:
				blue -= .01960784313f;
				break;
		}

		count += 5;
		colorStart = new Color(red, green, blue, 255);
		mat.color = colorStart;
		
		/************************************
		 * resets numbers that need reseting
		 ***********************************/
		if (count == 255)
		{
			count = 0;
			RGB = (RGB + 1) % 6;
		}
	}
}
