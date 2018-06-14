using UnityEngine;

public class MaterialColorChange : MonoBehaviour {
	
	private Color colorStart;
	private Color colorEnd;
	private Renderer rend;

	/*********************************
	* Use this for initialization
	*********************************/
	void Start ()
	{
		rend = GetComponent<Renderer>();
		colorStart = rend.material.color;
		//constructing the End Color through random numbers
		colorEnd = new Color(Random.Range(0.0f, 255.0f), Random.Range(0.0f, 255.0f), Random.Range(0.0f, 255.0f), 255);
//		Debug.Log(colorEnd);
	}
	
	/*************************************
	* Update is called once per frame
	*************************************/
	void Update ()
	{
		float lerp = Mathf.PingPong(Time.time, 1.0f);
		rend.material.color = Color.Lerp(colorStart, Color.blue, lerp);
//		Debug.Log("colorStart: ");
//		Debug.Log(colorStart);
//		Debug.Log("colorEnd: ");
//		Debug.Log(colorEnd);
	}
}
