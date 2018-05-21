using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float moveSpeed = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
	}
}
