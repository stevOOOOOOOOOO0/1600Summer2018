using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float MoveSpeed = 10;
    float jumpSpeed = 0;
    bool jumping = false;
    int gravity = 1;

   void Jump()
   {
      if (jumping == false && Input.GetAxis("Jump") == 1)
      {
         jumping = true;
         jumpSpeed = 20;
      }
      else if (transform.position.y <= 0.5f)
      {
         jumping = false;
         jumpSpeed = 0;
      }
      transform.Translate(0, jumpSpeed * Time.deltaTime, 0);
      if (jumping == true)
         jumpSpeed = jumpSpeed - gravity;
   }

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        // moving function

        transform.Translate(MoveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, MoveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);


      // jumping function
      Jump();
	}
}
