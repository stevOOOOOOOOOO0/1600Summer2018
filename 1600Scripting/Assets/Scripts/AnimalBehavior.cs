﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalBehavior : MonoBehaviour {

    public Animal AnimalInfo;

	// Use this for initialization
	void Start () {
        print(AnimalInfo.Health);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
