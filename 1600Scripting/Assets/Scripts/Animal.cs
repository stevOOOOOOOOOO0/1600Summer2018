using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

    // create variable i
    int counter = 150;

    public float Speed = 1;
    public int PowerLevel = 0;
    public string PlayerName = "Unknown";

	// Use this for initialization
	void Start () {

	}

    // Update is called once per frame
    void Update() {
        if (counter < 300)
        {
            transform.Rotate(0, Speed, 0);
            counter++;
        }
        else
        {
            transform.Rotate(0, Speed * -1, 0);
            counter++;
        }
        if (counter == 600)
            counter = counter % 20;
        transform.Translate(Speed, 0, 0);

    }
}
