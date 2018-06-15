using UnityEngine;

public class MaterialColorChange : MonoBehaviour {
	
	private Color colorStart;
	private Color colorEnd;
	private Renderer rend;
	private int red = 0;
	private int green = 0;
	private int blue = 0;
	private int count = 0;
	private int RGB = 0;

	/*********************************
	* Use this for initialization
	*********************************/
	void Start ()
	{
		rend = GetComponent<Renderer>();
		//constructing the Start color set to red
		colorStart = new Color(255, 0, 0, 255);
	}
	
	/*************************************
	* Update is called once per frame
	*************************************/
	void Update ()
	{
		if (RGB == 0)
			green += 5;
		else if (RGB == 1)
			red -= 5;
		else if (RGB == 2)
			blue += 5;
		else if (RGB == 3)
			green -= 5;
		else if (RGB == 4)
			red += 5;
		else if (RGB ==5)
			blue -= 5;

		count += 5;
		colorStart = new Color(red, green, blue, 255);
		rend.material.color = colorStart;
		
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
